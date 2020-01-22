namespace IvanovDDBPI182
{
    partial class AddLayerForm
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
            this.NameOfLayerTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameOfLayerTextBox
            // 
            this.NameOfLayerTextBox.Location = new System.Drawing.Point(15, 25);
            this.NameOfLayerTextBox.Name = "NameOfLayerTextBox";
            this.NameOfLayerTextBox.Size = new System.Drawing.Size(203, 20);
            this.NameOfLayerTextBox.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(99, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Введите имя слоя";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(146, 48);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(72, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "Добавить";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 83);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.NameOfLayerTextBox);
            this.MaximumSize = new System.Drawing.Size(241, 122);
            this.MinimumSize = new System.Drawing.Size(241, 122);
            this.Name = "AddLayerForm";
            this.Text = "AddLayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameOfLayerTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button OKButton;
    }
}