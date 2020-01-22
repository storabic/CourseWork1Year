using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IvanovDDBPI182
{
    public partial class LayersManager : Form
    {
        private Dictionary<string, Layer> layers;
        private string choosenLayerName;

        /// <summary>
        /// Initializes a new instance of the <see cref="LayersManager"/> class.
        /// </summary>
        /// <param name="layers">The layers.</param>
        public LayersManager(Dictionary<string, Layer> layers)
        {
            InitializeComponent();
            ShowButtons(false);
            this.layers = layers;
            ListOfLayers.Items.AddRange(layers.Keys.ToArray());
        }

        /// <summary>
        /// Shows or hides control buttons.
        /// </summary>
        /// <param name="flag">if flag = true shows, else hides.</param>
        private void ShowButtons(bool flag)
        {
            HideLayerButton.Enabled = flag;
            LabelOpacityOfLayer.Enabled = flag;
            OpacityOfLayerBar.Enabled = flag;
            DeleteLayerButton.Enabled = flag;
            DeleteLayerWithContentButton.Enabled = flag;
            //ButtonDown.Enabled = flag;
            ButtonFullDown.Enabled = flag;
            //ButtonUp.Enabled = flag;
            ButtonFullUp.Enabled = flag;
            OpacityOfLayerBar.Value = 0;
            label0Opacity.Enabled = flag;
            label100Opacity.Enabled = flag;
        }

        /// <summary>
        /// Handles the Click event of the label0Opacity control, sets label opacity to 0
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label0Opacity_Click(object sender, EventArgs e)
        {
            OpacityOfLayerBar.Value = 0;
        }

        /// <summary>
        /// Handles the Click event of the label100Opacity control, sets label opacity to 100
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label100Opacity_Click(object sender, EventArgs e)
        {
            OpacityOfLayerBar.Value = 100;
        }

        /// <summary>
        /// Handles the ValueChanged event of the OpacityOfLayerBar control and updates opacity of layer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OpacityOfLayerBar_ValueChanged(object sender, EventArgs e)
        {
            layers[choosenLayerName].ChangeTransparency(OpacityOfLayerBar.Value);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ListOfLayers control, changes current layer.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void ListOfLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListOfLayers.Text.Length != 0)
            {
                try
                {
                    choosenLayerName = ListOfLayers.Text;
                    layers[choosenLayerName].ShowLayer();
                    ShowButtons(true);
                }
                catch
                {
                    var msgBoxResult = MessageBox.Show("Что-то пошло не так.\nВозможно, вы удалили объект этого слоя.\nРасформировать слой?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (msgBoxResult == DialogResult.Yes)
                    {
                        layers[ListOfLayers.Text].Delete();
                        ListOfLayers.Items.Remove(ListOfLayers.Text);
                        ListOfLayers.Text = "";
                    }
                    else if (msgBoxResult == DialogResult.No)
                    {
                        layers[choosenLayerName].RemoveMissingShapes();
                    }
                }
            }
            else
            {
                ShowButtons(false);
            }
        }

        /// <summary>
        /// Handles the Click event of the ButtonFullUp control, puts current layer on Z-coordinate on top.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void ButtonFullUp_Click(object sender, EventArgs e)
        {
            layers[choosenLayerName].ChangeLayerOverlay(2);
        }

        /// <summary>
        /// Handles the Click event of the ButtonFullDown control, puts current layer on Z-coordinate to the bottom.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void ButtonFullDown_Click(object sender, EventArgs e)
        {
            layers[choosenLayerName].ChangeLayerOverlay(-2);
        }

        /// <summary>
        /// Handles the CheckedChanged event of the HideLayerButton control, hides or shows the layer
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void HideLayerButton_CheckedChanged(object sender, EventArgs e)
        {
            layers[choosenLayerName].HideLayer(HideLayerButton.Checked);
        }

        /// <summary>
        /// Handles the Click event of the DeleteLayerButton control, deletes layer
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void DeleteLayerButton_Click(object sender, EventArgs e)
        {
            layers[choosenLayerName] = new Layer();
            layers.Remove(choosenLayerName);
            ListOfLayers.Items.Remove(choosenLayerName);
            ListOfLayers.Text = "";
            ShowButtons(false);
            MessageBox.Show("Слой был успешно удалён", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Handles the Click event of the DeleteLayerWithContentButton control, deletes layer and its content
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void DeleteLayerWithContentButton_Click(object sender, EventArgs e)
        {
            layers[choosenLayerName].DeleteContent();
            ListOfLayers.Items.Remove(ListOfLayers.Text);
            ListOfLayers.Text = "";
            layers.Remove(choosenLayerName);
            ShowButtons(false);
            MessageBox.Show("Слой со всем содержимым был успешно удалён", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}