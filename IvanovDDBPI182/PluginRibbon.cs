using System;
using System.Collections.Generic;
using Microsoft.Office.Tools.Ribbon;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Windows.Forms;

namespace IvanovDDBPI182
{
    public partial class PluginRibbon
    {
        public PowerPoint.Slide CurrentSlide { set; get; }
        public Dictionary<string, Layer> CurrentLayers { set; get; }
        public Dictionary<string, Group> CurrentGroups { set; get; }
        public RangeOfShapes copies;
        public List<RangeOfShapes> allSimiliars;

        /// <summary>
        /// Events cintrols slide selection to always have link on opened slide
        /// </summary>
        /// <param name="slideRange"></param>
        private void OnSlideSelectionChanged(PowerPoint.SlideRange slideRange)
        {
            try
            {
                CurrentSlide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            }
            catch
            {
            }
        }

        /// <summary>
        /// Called when opening another presentation.
        /// </summary>
        /// <param name="presentation">The presentation.</param>
        private void OnOpeningNewPresentation(PowerPoint.Presentation presentation)
        {
            CurrentGroups = new Dictionary<string, Group>();
            CurrentLayers = new Dictionary<string, Layer>();
        }
        /// <summary>
        /// On plugin ribbon load creates new layer and group
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PluginRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            Globals.ThisAddIn.Application.AfterPresentationOpen += new PowerPoint.EApplication_AfterPresentationOpenEventHandler(OnOpeningNewPresentation);
            Globals.ThisAddIn.Application.AfterNewPresentation += new PowerPoint.EApplication_AfterNewPresentationEventHandler(OnOpeningNewPresentation);
            Globals.ThisAddIn.Application.SlideSelectionChanged += new PowerPoint.EApplication_SlideSelectionChangedEventHandler(OnSlideSelectionChanged);
            CurrentLayers = new Dictionary<string, Layer>();
            CurrentGroups = new Dictionary<string, Group>();
        }

        /// <summary>
        /// Gets correct link to source website from URL
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        private string GetSourceFromURL(string URL)
        {
            string res = "";
            bool flag = false;
            for (int i = 0; i < URL.Length; i++)
            {
                if (URL[i] == '.')
                    flag = true;
                if (flag && URL[i] == '/')
                    break;
                res += URL[i];
            }
            res = res.Replace("https://", "Источник : ");
            res = res.Replace("http://", "Источник : ");
            return res;
        }

        /// <summary>
        /// Pastes image and link on its source via URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteImageWithLinkButton_Click(object sender, RibbonControlEventArgs e)
        {
            PowerPoint.Slide slide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
            try
            {
                if (System.Windows.Clipboard.ContainsText())
                {
                    string text = System.Windows.Clipboard.GetText();

                    var picture = slide.Shapes.AddPicture(text, Office.MsoTriState.msoFalse, Office.MsoTriState.msoTrue, 0, 0, -1, -1);
                    var linkTextBox = slide.Shapes.AddTextbox(Office.MsoTextOrientation.msoTextOrientationHorizontal, 0, picture.Height, picture.Width, 50);

                    text = GetSourceFromURL(text);
                    linkTextBox.ShapeStyle = Office.MsoShapeStyleIndex.msoShapeStylePreset1;
                    linkTextBox.TextFrame.TextRange.Text = text;
                }
                else
                    throw new ArgumentException();
            }
            catch
            {
                MessageBox.Show("В буфере обмена не найдено URL рисунка");
            }
        }

        /// <summary>
        /// Show Layers by selecting them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowLayersButton_Click(object sender, RibbonControlEventArgs e)
        {
            var layersManager = new LayersManager(CurrentLayers);
            layersManager.Show();
        }

        /// <summary>
        /// Adds new layer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLayerButton_Click(object sender, RibbonControlEventArgs e)
        {
            if (CurrentLayers.Count > 20)
            {
                MessageBox.Show("Нельзя создать больше чем 20 слоёв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
            }
            catch
            {
                MessageBox.Show("Не найдено выбранных объектов слайда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool flag = false;
            foreach (PowerPoint.Shape shapeToCheck in selectedShapes)
            {
                foreach (Layer layer in CurrentLayers.Values)
                {
                    if (layer.ShapeIsInLayer(shapeToCheck))
                        flag = true;
                }
            }
            if (flag)
            {
                MessageBox.Show("Один из выбранных объектов уже состоит в слое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (PowerPoint.Shape shape in selectedShapes)
            {
                if (shape.Type == Office.MsoShapeType.msoPicture || shape.Type == Office.MsoShapeType.msoLinkedPicture)
                {
                    MessageBox.Show("К сожалению, нельзя добавить в слой " +
                        "элемент типа \"рисунок\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Layer layerToAdd = new Layer(selectedShapes);
            var addLayerForm = new AddLayerForm(CurrentLayers, layerToAdd);
            addLayerForm.ShowDialog();
        }

        /// <summary>
        /// Searches copies and launches Edit Tools Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchCopiesButton_Click(object sender, RibbonControlEventArgs e)
        {
            copies = new RangeOfShapes();
            var selectedItems = Globals.ThisAddIn.Application.ActiveWindow.Selection;
            if (selectedItems.Type == PowerPoint.PpSelectionType.ppSelectionShapes && selectedItems.ShapeRange.Count == 1)
            {
                PowerPoint.Shape selectedShape = selectedItems.ShapeRange[1];
                copies.Add(selectedShape);
                foreach (PowerPoint.Slide slide in Globals.ThisAddIn.Application.ActivePresentation.Slides)
                {
                    foreach (PowerPoint.Shape shape in slide.Shapes)
                    {
                        if (ShapesAreEqual(shape, selectedShape))
                            copies.Add(shape);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (copies.Count() == 1)
                MessageBox.Show($"Не было найдено копий");
            else
            {
                EditToolsForm editTools = new EditToolsForm(copies);
                editTools.Show();
            }
        }

        /// <summary>
        /// checks if shapes are equal
        /// </summary>
        /// <param name="shape1"></param>
        /// <param name="shape2"></param>
        /// <returns>shape1 == shape2</returns>
        private bool ShapesAreEqual(PowerPoint.Shape shape1, PowerPoint.Shape shape2)
        {
            if (shape1 == shape2)
                return false;
            if (shape1.Type == Office.MsoShapeType.msoTextBox && shape2.Type == Office.MsoShapeType.msoTextBox)
                if (shape1.TextFrame.TextRange.Text == shape2.TextFrame.TextRange.Text)
                    return true;
            if (shape1.Type == shape2.Type)
                if (shape1.Fill.ForeColor == shape2.Fill.ForeColor && shape1.Fill.BackColor == shape2.Fill.BackColor && 
                    shape1.Width == shape2.Width && shape1.Height == shape2.Height)
                    return true;
            return false;
        }

        /// <summary>
        /// Handles the Click event of the GroupManagerButton control and launches Group Manager.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RibbonControlEventArgs"/> instance containing the event data.</param>
        private void GroupManagerButton_Click(object sender, RibbonControlEventArgs e)
        {
            GroupsManager groupsManager = new GroupsManager(CurrentGroups);
            groupsManager.Show();
        }

        /// <summary>
        /// Handles the Click event of the ApplyStyleForAllSimiliarsButton control, looks for similiars and launches Edit Tools
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs" /> instance containing the event data.</param>
        private void ApplyStyleForAllSimiliarsButton_Click(object sender, RibbonControlEventArgs e)
        {
            var selectedItems = Globals.ThisAddIn.Application.ActiveWindow.Selection;
            if (selectedItems.Type == PowerPoint.PpSelectionType.ppSelectionShapes && selectedItems.ShapeRange.Count == 1)
            {
                var originalShape = selectedItems.ShapeRange[1];
                var typeOfOriginalShape = originalShape.Type;
                var style = originalShape.ShapeStyle;
                RangeOfShapes similiars = new RangeOfShapes();
                foreach (PowerPoint.Slide slide in Globals.ThisAddIn.Application.ActivePresentation.Slides)
                {
                    foreach (PowerPoint.Shape shape in slide.Shapes)
                        if ((shape.Type == typeOfOriginalShape && shape.ShapeStyle == style && style != Office.MsoShapeStyleIndex.msoShapeStyleNotAPreset) || (typeOfOriginalShape == Office.MsoShapeType.msoTextBox && style == Office.MsoShapeStyleIndex.msoShapeStyleNotAPreset &&
                            shape.Type == Office.MsoShapeType.msoTextBox && shape.TextFrame.TextRange.Font == originalShape.TextFrame.TextRange.Font))
                            similiars.Add(shape);
                }
                if (similiars.Count() != 0)
                {
                    EditToolsForm editTools = new EditToolsForm(similiars);
                    editTools.Show();
                }
                else
                {
                    MessageBox.Show("Не найдено похожих по стилю элементов", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Handles the Click event of the ApplyStyleForAllSimiliarsThisSlideButton control, looks for similiars on current slide and launches Edit Tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyStyleForSimiliarsThisSlideButton_Click(object sender, RibbonControlEventArgs e)
        {
            PowerPoint.Shape selectedShape;
            try
            {
                var selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                    throw new ArgumentException();
                selectedShape = selectedShapes[1];
            }
            catch
            {
                MessageBox.Show("Выберите объект, для которого вы хотите найти похожие элементы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int count = 0;
            foreach (PowerPoint.Shape shape in Globals.ThisAddIn.Application.ActiveWindow.View.Slide.Shapes)
            {
                if (shape != selectedShape && shape.Type == selectedShape.Type)
                {
                    shape.Select(Office.MsoTriState.msoFalse);
                    count++;
                }
            }
            if (count == 0)
            {
                MessageBox.Show("Не было найдено похожих элементов на этом слайде", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Выбрано {count} похожих элементов на текущем слайде", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}