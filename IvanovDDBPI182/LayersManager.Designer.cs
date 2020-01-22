namespace IvanovDDBPI182
{
    partial class LayersManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonFullDown = new System.Windows.Forms.Button();
            this.ButtonFullUp = new System.Windows.Forms.Button();
            this.DeleteLayerWithContentButton = new System.Windows.Forms.Button();
            this.DeleteLayerButton = new System.Windows.Forms.Button();
            this.LabelOpacityOfLayer = new System.Windows.Forms.Label();
            this.OpacityOfLayerBar = new System.Windows.Forms.TrackBar();
            this.HideLayerButton = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListOfLayers = new System.Windows.Forms.ComboBox();
            this.label100Opacity = new System.Windows.Forms.Label();
            this.label0Opacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityOfLayerBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFullDown
            // 
            this.ButtonFullDown.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonFullDown.Location = new System.Drawing.Point(232, 153);
            this.ButtonFullDown.Name = "ButtonFullDown";
            this.ButtonFullDown.Size = new System.Drawing.Size(106, 23);
            this.ButtonFullDown.TabIndex = 21;
            this.ButtonFullDown.Text = "Поверх всего ↥";
            this.ButtonFullDown.UseVisualStyleBackColor = false;
            this.ButtonFullDown.Click += new System.EventHandler(this.ButtonFullDown_Click);
            // 
            // ButtonFullUp
            // 
            this.ButtonFullUp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonFullUp.Location = new System.Drawing.Point(232, 124);
            this.ButtonFullUp.Name = "ButtonFullUp";
            this.ButtonFullUp.Size = new System.Drawing.Size(106, 23);
            this.ButtonFullUp.TabIndex = 19;
            this.ButtonFullUp.Text = "В самый низ ↧";
            this.ButtonFullUp.UseVisualStyleBackColor = false;
            this.ButtonFullUp.Click += new System.EventHandler(this.ButtonFullUp_Click);
            // 
            // DeleteLayerWithContentButton
            // 
            this.DeleteLayerWithContentButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteLayerWithContentButton.Location = new System.Drawing.Point(12, 153);
            this.DeleteLayerWithContentButton.Name = "DeleteLayerWithContentButton";
            this.DeleteLayerWithContentButton.Size = new System.Drawing.Size(187, 23);
            this.DeleteLayerWithContentButton.TabIndex = 17;
            this.DeleteLayerWithContentButton.Text = "Удалить слой и всё содержимое";
            this.DeleteLayerWithContentButton.UseVisualStyleBackColor = false;
            this.DeleteLayerWithContentButton.Click += new System.EventHandler(this.DeleteLayerWithContentButton_Click);
            // 
            // DeleteLayerButton
            // 
            this.DeleteLayerButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteLayerButton.Location = new System.Drawing.Point(12, 124);
            this.DeleteLayerButton.Name = "DeleteLayerButton";
            this.DeleteLayerButton.Size = new System.Drawing.Size(121, 23);
            this.DeleteLayerButton.TabIndex = 16;
            this.DeleteLayerButton.Text = "Удалить слой";
            this.DeleteLayerButton.UseVisualStyleBackColor = false;
            this.DeleteLayerButton.Click += new System.EventHandler(this.DeleteLayerButton_Click);
            // 
            // LabelOpacityOfLayer
            // 
            this.LabelOpacityOfLayer.AutoSize = true;
            this.LabelOpacityOfLayer.Location = new System.Drawing.Point(232, 49);
            this.LabelOpacityOfLayer.Name = "LabelOpacityOfLayer";
            this.LabelOpacityOfLayer.Size = new System.Drawing.Size(106, 13);
            this.LabelOpacityOfLayer.TabIndex = 15;
            this.LabelOpacityOfLayer.Text = "Прозрачность слоя";
            // 
            // OpacityOfLayerBar
            // 
            this.OpacityOfLayerBar.Location = new System.Drawing.Point(232, 65);
            this.OpacityOfLayerBar.Maximum = 100;
            this.OpacityOfLayerBar.Name = "OpacityOfLayerBar";
            this.OpacityOfLayerBar.Size = new System.Drawing.Size(101, 45);
            this.OpacityOfLayerBar.TabIndex = 14;
            this.OpacityOfLayerBar.TickFrequency = 5;
            this.OpacityOfLayerBar.ValueChanged += new System.EventHandler(this.OpacityOfLayerBar_ValueChanged);
            // 
            // HideLayerButton
            // 
            this.HideLayerButton.AutoSize = true;
            this.HideLayerButton.BackColor = System.Drawing.SystemColors.Window;
            this.HideLayerButton.Location = new System.Drawing.Point(247, 26);
            this.HideLayerButton.Name = "HideLayerButton";
            this.HideLayerButton.Size = new System.Drawing.Size(91, 17);
            this.HideLayerButton.TabIndex = 13;
            this.HideLayerButton.Text = "Скрыть слой";
            this.HideLayerButton.UseVisualStyleBackColor = false;
            this.HideLayerButton.CheckedChanged += new System.EventHandler(this.HideLayerButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Слой";
            // 
            // ListOfLayers
            // 
            this.ListOfLayers.BackColor = System.Drawing.SystemColors.Window;
            this.ListOfLayers.FormattingEnabled = true;
            this.ListOfLayers.Location = new System.Drawing.Point(12, 24);
            this.ListOfLayers.Name = "ListOfLayers";
            this.ListOfLayers.Size = new System.Drawing.Size(121, 21);
            this.ListOfLayers.TabIndex = 11;
            this.ListOfLayers.SelectedIndexChanged += new System.EventHandler(this.ListOfLayers_SelectedIndexChanged);
            // 
            // label100Opacity
            // 
            this.label100Opacity.AutoSize = true;
            this.label100Opacity.Location = new System.Drawing.Point(324, 84);
            this.label100Opacity.Name = "label100Opacity";
            this.label100Opacity.Size = new System.Drawing.Size(25, 13);
            this.label100Opacity.TabIndex = 22;
            this.label100Opacity.Text = "100";
            this.label100Opacity.Click += new System.EventHandler(this.label100Opacity_Click);
            // 
            // label0Opacity
            // 
            this.label0Opacity.AutoSize = true;
            this.label0Opacity.Location = new System.Drawing.Point(229, 84);
            this.label0Opacity.Name = "label0Opacity";
            this.label0Opacity.Size = new System.Drawing.Size(13, 13);
            this.label0Opacity.TabIndex = 23;
            this.label0Opacity.Text = "0";
            this.label0Opacity.Click += new System.EventHandler(this.label0Opacity_Click);
            // 
            // LayersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(350, 187);
            this.Controls.Add(this.label0Opacity);
            this.Controls.Add(this.label100Opacity);
            this.Controls.Add(this.ButtonFullDown);
            this.Controls.Add(this.ButtonFullUp);
            this.Controls.Add(this.DeleteLayerWithContentButton);
            this.Controls.Add(this.DeleteLayerButton);
            this.Controls.Add(this.LabelOpacityOfLayer);
            this.Controls.Add(this.OpacityOfLayerBar);
            this.Controls.Add(this.HideLayerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOfLayers);
            this.MaximumSize = new System.Drawing.Size(366, 226);
            this.MinimumSize = new System.Drawing.Size(366, 226);
            this.Name = "LayersManager";
            this.Text = "Менеджер слоёв";
            ((System.ComponentModel.ISupportInitialize)(this.OpacityOfLayerBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFullDown;
        private System.Windows.Forms.Button ButtonFullUp;
        private System.Windows.Forms.Button DeleteLayerWithContentButton;
        private System.Windows.Forms.Button DeleteLayerButton;
        private System.Windows.Forms.Label LabelOpacityOfLayer;
        private System.Windows.Forms.TrackBar OpacityOfLayerBar;
        private System.Windows.Forms.CheckBox HideLayerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListOfLayers;
        private System.Windows.Forms.Label label100Opacity;
        private System.Windows.Forms.Label label0Opacity;
    }
}