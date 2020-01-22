using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IvanovDDBPI182
{
    public partial class AddLayerForm : Form
    {
        Layer layerToAdd;
        Dictionary<string, Layer> currentLayers;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLayerForm"/> class.
        /// </summary>
        /// <param name="currentLayers">The current layers.</param>
        /// <param name="layerToAdd">The layer to add.</param>
        public AddLayerForm(Dictionary<string, Layer> currentLayers, Layer layerToAdd)
        {
            InitializeComponent();
            this.currentLayers = currentLayers;
            this.layerToAdd = layerToAdd;
        }

        /// <summary>
        /// Handles the Click event of the OKButton control and sets the name of new layer
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            string text = NameOfLayerTextBox.Text;
            if (text.Length > 20 || text.Length < 4)
            {
                MessageBox.Show("Имя слоя должно состоять из не менее чем 4 и не более чем из 20 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text.Contains(" "))
            {
                MessageBox.Show("Имя группы не может содержать пробелов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var bannedText in currentLayers.Keys)
                if (bannedText == text)
                {
                    MessageBox.Show("Слой с таким именем уже существует.\nПридумайте другое имя или удлалите существующмй слой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameOfLayerTextBox.Text = "";
                    return;
                }
            currentLayers.Add(text, layerToAdd); 
            MessageBox.Show($"Слой {text} был успешно добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}