using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace IvanovDDBPI182
{
    public partial class EditToolsForm : Form
    {
        private RangeOfShapes shapes;

        //flags of current format of font
        private Office.MsoTriState flagBold;
        private Office.MsoTriState flagUnderline;
        private Office.MsoTriState flagStrike;
        private Office.MsoTriState flagItalic;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditToolsForm"/> class, styles all buttons and sets list of fonts.
        /// </summary>
        /// <param name="shapes">The shapes.</param>
        public EditToolsForm(RangeOfShapes shapes)
        {
            InitializeComponent();
            this.shapes = shapes;
            MakeBoldButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            MakeBoldButton.FlatAppearance.BorderColor = Color.White;
            MakeItalicButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Italic);
            MakeItalicButton.FlatAppearance.BorderColor = Color.White;
            MakeUnderlineButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline);
            MakeUnderlineButton.FlatAppearance.BorderColor = Color.White;
            MakeStrikeButton.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Strikeout);
            MakeStrikeButton.FlatAppearance.BorderColor = Color.White;
            UnformatTextButton.FlatAppearance.BorderColor = Color.White;
            List<string> fonts = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
            }
            ListOfFonts.Items.AddRange(fonts.ToArray());
            flagBold = Office.MsoTriState.msoFalse;
            flagUnderline = Office.MsoTriState.msoFalse;
            flagStrike = Office.MsoTriState.msoFalse;
            flagItalic = Office.MsoTriState.msoFalse;
        }

        /// <summary>
        /// Handles the Click event of the UnformatTextButton control, undos all formatting of text.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UnformatTextButton_Click(object sender, EventArgs e)
        {
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame.TextRange.Font.Color.RGB = 0;
                    shapes.ShapesList.First().TextFrame.TextRange.Font.Italic = Office.MsoTriState.msoFalse;
                    shapes.ShapesList.First().TextFrame.TextRange.Font.Bold = Office.MsoTriState.msoFalse;
                    shapes.ShapesList.First().TextFrame.TextRange.Font.Underline = Office.MsoTriState.msoFalse;
                    shapes.ShapesList.First().TextFrame2.TextRange.Font.StrikeThrough = Office.MsoTriState.msoFalse;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ListOfFonts control, changes font.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ListOfFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame2.TextRange.Font.Name = ListOfFonts.Text;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Leave event of the FontSizeTextBox control, sets new font size.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void FontSizeTextBox_Leave(object sender, EventArgs e)
        {
            float fontSize;
            try
            {
                fontSize = float.Parse(FontSizeTextBox.Text);
                if (fontSize > 200)
                    throw new ArgumentException();
            }
            catch
            {
                FontSizeTextBox.Text = "10";
                return;
            }
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame2.TextRange.Font.Size = fontSize;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Click event of the FontColorButton control, setes font color using ColorDialog
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FontColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog fontColorDialog = new ColorDialog();
            fontColorDialog.AllowFullOpen = false;
            fontColorDialog.ShowHelp = true;
            if (fontColorDialog.ShowDialog() == DialogResult.OK)
                foreach (PowerPoint.Shape shape in shapes)
                    try
                    {
                        shape.TextFrame.TextRange.Font.Color.RGB = fontColorDialog.Color.B * 65536 + fontColorDialog.Color.G * 256 + fontColorDialog.Color.R;
                    }
                    catch
                    {
                        continue;
                    }
        }

        /// <summary>
        /// Handles the Click event of the MakeBoldButton control, makes text bold.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MakeBoldButton_Click(object sender, EventArgs e)
        {
            if (flagBold == Office.MsoTriState.msoFalse)
                flagBold = Office.MsoTriState.msoTrue;
            else
                flagBold = Office.MsoTriState.msoFalse;

            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame.TextRange.Font.Bold = flagBold;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Click event of the MakeItalicButton control, formats text to italic.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MakeItalicButton_Click(object sender, EventArgs e)
        {
            if (flagItalic == Office.MsoTriState.msoFalse)
                flagItalic = Office.MsoTriState.msoTrue;
            else
                flagItalic = Office.MsoTriState.msoFalse;
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame.TextRange.Font.Italic = flagItalic;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Click event of the MakeUnderlineButton control, makes text underline.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MakeUnderlineButton_Click(object sender, EventArgs e)
        {
            if (flagUnderline == Office.MsoTriState.msoFalse)
                flagUnderline = Office.MsoTriState.msoTrue;
            else
                flagUnderline = Office.MsoTriState.msoFalse;
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame.TextRange.Font.Underline = flagUnderline;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Click event of the MakeStrikeButton control, makes font striked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MakeStrikeButton_Click(object sender, EventArgs e)
        {
            if (flagStrike == Office.MsoTriState.msoFalse)
                flagStrike = Office.MsoTriState.msoTrue;
            else
                flagStrike = Office.MsoTriState.msoFalse;
            foreach (PowerPoint.Shape shape in shapes)
                try
                {
                    shape.TextFrame2.TextRange.Font.StrikeThrough = flagStrike;
                }
                catch
                {
                    continue;
                }
        }

        /// <summary>
        /// Handles the Click event of the ShapeColorButton control, changes color of shape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ShapeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog ShapeColorDialog = new ColorDialog();
            ShapeColorDialog.AllowFullOpen = false;
            ShapeColorDialog.ShowHelp = true;
            if (ShapeColorDialog.ShowDialog() == DialogResult.OK)
                foreach (PowerPoint.Shape shape in shapes)
                    try
                    {
                        shape.Fill.BackColor.RGB = ShapeColorDialog.Color.B * 65536 + ShapeColorDialog.Color.G * 256 + ShapeColorDialog.Color.R;
                    }
                    catch
                    {
                        continue;
                    }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the LineWidth control, changes line width.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LineWidth_Leave(sender, e);
        }

        /// <summary>
        /// Handles the Leave event of the LineWidth control, changes line width.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LineWidth_Leave(object sender, EventArgs e)
        {
            float lineWidth;
            try
            {
                lineWidth = float.Parse(LineWidth.Text);
            }
            catch
            {
                LineWidth.Text = "1";
                return;
            }
            foreach (PowerPoint.Shape shape in shapes)
            {
                try
                {
                    shape.Line.Weight = lineWidth;
                }
                catch
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the ForeColorButton control, changes fore color of shape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ForeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog ShapeColorDialog = new ColorDialog();
            ShapeColorDialog.AllowFullOpen = false;
            ShapeColorDialog.ShowHelp = true;
            if (ShapeColorDialog.ShowDialog() == DialogResult.OK)
                foreach (PowerPoint.Shape shape in shapes)
                    try
                    {
                        shape.Fill.ForeColor.RGB = ShapeColorDialog.Color.B * 65536 + ShapeColorDialog.Color.G * 256 + ShapeColorDialog.Color.R;
                    }
                    catch
                    {
                        continue;
                    }
        }

        /// <summary>
        /// Handles the Click event of the ApplyChoosenShapeFormat control, sets choosen shape-like format to all elems
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void ApplyChoosenShapeFormat_Click(object sender, EventArgs e)
        {
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект, стиль которого будет копироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            selectedShapes[1].PickUp();
            foreach (PowerPoint.Shape shape in shapes)
            {
                try
                {
                    var width = shape.Width;
                    var height = shape.Height;
                    var left = shape.Left;
                    var top = shape.Top;
                    shape.Apply();
                    shape.Width = width;
                    shape.Height = height;
                    shape.Top = top;
                    shape.Left = left;
                }
                catch
                {
                    continue;
                }
            }
        }


        /// <summary>
        /// Handles the Click event of the ApplySize control, changes size of elements just like choosen object.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void ApplySize_Click(object sender, EventArgs e)
        {
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект, стиль которого будет копироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (PowerPoint.Shape shape in shapes)
            {
                if (shape.Type == Office.MsoShapeType.msoPicture)
                    try
                    {
                        var width = selectedShapes[1].Width;
                        var height = selectedShapes[1].Height;
                        shape.Width = width;
                        shape.Height = height;
                    }
                    catch
                    {
                        continue;
                    }
            }
        }

        /// <summary>
        /// Handles the Click event of the ApplyPosition control, sets position of all elems just like choosen shape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void ApplyPosition_Click(object sender, EventArgs e)
        {
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект, стиль которого будет копироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            selectedShapes[1].PickUp();
            foreach (PowerPoint.Shape shape in shapes)
            {
                try
                {
                    var left = selectedShapes[1].Left;
                    var top = selectedShapes[1].Top;
                    shape.Top = top;
                    shape.Left = left;
                }
                catch
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the AutoShapeSize control, changes size of shapes just like choosen shape.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void AutoShapeSize_Click(object sender, EventArgs e)
        {
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект, стиль которого будет копироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (PowerPoint.Shape shape in shapes)
            {
                if(shape.Type == Office.MsoShapeType.msoAutoShape)
                try
                {
                    var width = selectedShapes[1].Width;
                    var height = selectedShapes[1].Height;
                    shape.Width = width;
                    shape.Height = height;
                }
                catch
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the TextFrameSize control, changes TextBoxes size just like choosen shape
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentException"></exception>
        private void TextFrameSize_Click(object sender, EventArgs e)
        {
            PowerPoint.ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
                if (selectedShapes.Count > 1)
                {
                    throw new ArgumentException();
                }
            }
            catch
            {
                MessageBox.Show("Выберите объект, стиль которого будет копироваться", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (PowerPoint.Shape shape in shapes)
            {
                if (shape.Type == Office.MsoShapeType.msoTextBox)
                    try
                    {
                        var width = selectedShapes[1].Width;
                        var height = selectedShapes[1].Height;
                        shape.Width = width;
                        shape.Height = height;
                    }
                    catch
                    {
                        continue;
                    }
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonFontSizeOK control, sets new size of font.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonFontSizeOK_Click(object sender, EventArgs e)
        {
            FontSizeTextBox_Leave(sender, e);
        }
    }
}