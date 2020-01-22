namespace IvanovDDBPI182
{
    partial class EditToolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditToolsForm));
            this.FontSection = new System.Windows.Forms.GroupBox();
            this.buttonFontSizeOK = new System.Windows.Forms.Button();
            this.UnformatTextButton = new System.Windows.Forms.Button();
            this.MakeStrikeButton = new System.Windows.Forms.Button();
            this.ListOfFonts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FontSizeTextBox = new System.Windows.Forms.TextBox();
            this.MakeUnderlineButton = new System.Windows.Forms.Button();
            this.MakeItalicButton = new System.Windows.Forms.Button();
            this.MakeBoldButton = new System.Windows.Forms.Button();
            this.FontColorButton = new System.Windows.Forms.Button();
            this.FiguresSection = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LineWidth = new System.Windows.Forms.ComboBox();
            this.ApplyChoosenShapeFormat = new System.Windows.Forms.Button();
            this.ForeColorButton = new System.Windows.Forms.Button();
            this.ShapeColorButton = new System.Windows.Forms.Button();
            this.PositionAndSize = new System.Windows.Forms.GroupBox();
            this.TextFrameSize = new System.Windows.Forms.Button();
            this.AutoShapeSize = new System.Windows.Forms.Button();
            this.ApplyPosition = new System.Windows.Forms.Button();
            this.PictureSize = new System.Windows.Forms.Button();
            this.FontSection.SuspendLayout();
            this.FiguresSection.SuspendLayout();
            this.PositionAndSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontSection
            // 
            this.FontSection.Controls.Add(this.buttonFontSizeOK);
            this.FontSection.Controls.Add(this.UnformatTextButton);
            this.FontSection.Controls.Add(this.MakeStrikeButton);
            this.FontSection.Controls.Add(this.ListOfFonts);
            this.FontSection.Controls.Add(this.label1);
            this.FontSection.Controls.Add(this.FontSizeTextBox);
            this.FontSection.Controls.Add(this.MakeUnderlineButton);
            this.FontSection.Controls.Add(this.MakeItalicButton);
            this.FontSection.Controls.Add(this.MakeBoldButton);
            this.FontSection.Controls.Add(this.FontColorButton);
            this.FontSection.Location = new System.Drawing.Point(12, 12);
            this.FontSection.Name = "FontSection";
            this.FontSection.Size = new System.Drawing.Size(258, 115);
            this.FontSection.TabIndex = 0;
            this.FontSection.TabStop = false;
            this.FontSection.Text = "Текст";
            // 
            // buttonFontSizeOK
            // 
            this.buttonFontSizeOK.Location = new System.Drawing.Point(57, 55);
            this.buttonFontSizeOK.Name = "buttonFontSizeOK";
            this.buttonFontSizeOK.Size = new System.Drawing.Size(31, 23);
            this.buttonFontSizeOK.TabIndex = 11;
            this.buttonFontSizeOK.Text = "OK";
            this.buttonFontSizeOK.UseVisualStyleBackColor = true;
            this.buttonFontSizeOK.Click += new System.EventHandler(this.buttonFontSizeOK_Click);
            // 
            // UnformatTextButton
            // 
            this.UnformatTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnformatTextButton.Image = ((System.Drawing.Image)(resources.GetObject("UnformatTextButton.Image")));
            this.UnformatTextButton.Location = new System.Drawing.Point(228, 81);
            this.UnformatTextButton.Name = "UnformatTextButton";
            this.UnformatTextButton.Size = new System.Drawing.Size(23, 23);
            this.UnformatTextButton.TabIndex = 10;
            this.UnformatTextButton.UseVisualStyleBackColor = true;
            this.UnformatTextButton.Click += new System.EventHandler(this.UnformatTextButton_Click);
            // 
            // MakeStrikeButton
            // 
            this.MakeStrikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeStrikeButton.Location = new System.Drawing.Point(221, 28);
            this.MakeStrikeButton.Name = "MakeStrikeButton";
            this.MakeStrikeButton.Size = new System.Drawing.Size(30, 23);
            this.MakeStrikeButton.TabIndex = 9;
            this.MakeStrikeButton.Text = "ab";
            this.MakeStrikeButton.UseVisualStyleBackColor = true;
            this.MakeStrikeButton.Click += new System.EventHandler(this.MakeStrikeButton_Click);
            // 
            // ListOfFonts
            // 
            this.ListOfFonts.FormattingEnabled = true;
            this.ListOfFonts.Location = new System.Drawing.Point(6, 28);
            this.ListOfFonts.Name = "ListOfFonts";
            this.ListOfFonts.Size = new System.Drawing.Size(121, 21);
            this.ListOfFonts.TabIndex = 8;
            this.ListOfFonts.SelectedIndexChanged += new System.EventHandler(this.ListOfFonts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер";
            // 
            // FontSizeTextBox
            // 
            this.FontSizeTextBox.Location = new System.Drawing.Point(7, 55);
            this.FontSizeTextBox.Name = "FontSizeTextBox";
            this.FontSizeTextBox.Size = new System.Drawing.Size(43, 20);
            this.FontSizeTextBox.TabIndex = 6;
            this.FontSizeTextBox.Leave += new System.EventHandler(this.FontSizeTextBox_Leave);
            // 
            // MakeUnderlineButton
            // 
            this.MakeUnderlineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeUnderlineButton.Location = new System.Drawing.Point(191, 28);
            this.MakeUnderlineButton.Name = "MakeUnderlineButton";
            this.MakeUnderlineButton.Size = new System.Drawing.Size(23, 23);
            this.MakeUnderlineButton.TabIndex = 5;
            this.MakeUnderlineButton.Text = "Ч";
            this.MakeUnderlineButton.UseVisualStyleBackColor = true;
            this.MakeUnderlineButton.Click += new System.EventHandler(this.MakeUnderlineButton_Click);
            // 
            // MakeItalicButton
            // 
            this.MakeItalicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeItalicButton.Location = new System.Drawing.Point(162, 28);
            this.MakeItalicButton.Name = "MakeItalicButton";
            this.MakeItalicButton.Size = new System.Drawing.Size(23, 23);
            this.MakeItalicButton.TabIndex = 4;
            this.MakeItalicButton.Text = "К";
            this.MakeItalicButton.UseVisualStyleBackColor = true;
            this.MakeItalicButton.Click += new System.EventHandler(this.MakeItalicButton_Click);
            // 
            // MakeBoldButton
            // 
            this.MakeBoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeBoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MakeBoldButton.Location = new System.Drawing.Point(133, 28);
            this.MakeBoldButton.Name = "MakeBoldButton";
            this.MakeBoldButton.Size = new System.Drawing.Size(23, 23);
            this.MakeBoldButton.TabIndex = 3;
            this.MakeBoldButton.Text = "Ж";
            this.MakeBoldButton.UseVisualStyleBackColor = true;
            this.MakeBoldButton.Click += new System.EventHandler(this.MakeBoldButton_Click);
            // 
            // FontColorButton
            // 
            this.FontColorButton.Location = new System.Drawing.Point(7, 81);
            this.FontColorButton.Name = "FontColorButton";
            this.FontColorButton.Size = new System.Drawing.Size(120, 23);
            this.FontColorButton.TabIndex = 2;
            this.FontColorButton.Text = "Цвет шрифта";
            this.FontColorButton.UseVisualStyleBackColor = true;
            this.FontColorButton.Click += new System.EventHandler(this.FontColorButton_Click);
            // 
            // FiguresSection
            // 
            this.FiguresSection.Controls.Add(this.label2);
            this.FiguresSection.Controls.Add(this.LineWidth);
            this.FiguresSection.Controls.Add(this.ApplyChoosenShapeFormat);
            this.FiguresSection.Controls.Add(this.ForeColorButton);
            this.FiguresSection.Controls.Add(this.ShapeColorButton);
            this.FiguresSection.Location = new System.Drawing.Point(276, 13);
            this.FiguresSection.Name = "FiguresSection";
            this.FiguresSection.Size = new System.Drawing.Size(268, 114);
            this.FiguresSection.TabIndex = 1;
            this.FiguresSection.TabStop = false;
            this.FiguresSection.Text = "Фигуры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина линий";
            // 
            // LineWidth
            // 
            this.LineWidth.FormattingEnabled = true;
            this.LineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.LineWidth.Location = new System.Drawing.Point(116, 29);
            this.LineWidth.Name = "LineWidth";
            this.LineWidth.Size = new System.Drawing.Size(36, 21);
            this.LineWidth.TabIndex = 4;
            this.LineWidth.SelectedIndexChanged += new System.EventHandler(this.LineWidth_SelectedIndexChanged);
            this.LineWidth.Leave += new System.EventHandler(this.LineWidth_Leave);
            // 
            // ApplyChoosenShapeFormat
            // 
            this.ApplyChoosenShapeFormat.Location = new System.Drawing.Point(139, 72);
            this.ApplyChoosenShapeFormat.Name = "ApplyChoosenShapeFormat";
            this.ApplyChoosenShapeFormat.Size = new System.Drawing.Size(123, 36);
            this.ApplyChoosenShapeFormat.TabIndex = 3;
            this.ApplyChoosenShapeFormat.Text = "Применить стиль выбранного объекта";
            this.ApplyChoosenShapeFormat.UseVisualStyleBackColor = true;
            this.ApplyChoosenShapeFormat.Click += new System.EventHandler(this.ApplyChoosenShapeFormat_Click);
            // 
            // ForeColorButton
            // 
            this.ForeColorButton.Location = new System.Drawing.Point(6, 56);
            this.ForeColorButton.Name = "ForeColorButton";
            this.ForeColorButton.Size = new System.Drawing.Size(87, 23);
            this.ForeColorButton.TabIndex = 1;
            this.ForeColorButton.Text = "Цвет контура";
            this.ForeColorButton.UseVisualStyleBackColor = true;
            this.ForeColorButton.Click += new System.EventHandler(this.ForeColorButton_Click);
            // 
            // ShapeColorButton
            // 
            this.ShapeColorButton.Location = new System.Drawing.Point(6, 27);
            this.ShapeColorButton.Name = "ShapeColorButton";
            this.ShapeColorButton.Size = new System.Drawing.Size(87, 23);
            this.ShapeColorButton.TabIndex = 0;
            this.ShapeColorButton.Text = "Цвет заливки";
            this.ShapeColorButton.UseVisualStyleBackColor = true;
            this.ShapeColorButton.Click += new System.EventHandler(this.ShapeColorButton_Click);
            // 
            // PositionAndSize
            // 
            this.PositionAndSize.Controls.Add(this.TextFrameSize);
            this.PositionAndSize.Controls.Add(this.AutoShapeSize);
            this.PositionAndSize.Controls.Add(this.ApplyPosition);
            this.PositionAndSize.Controls.Add(this.PictureSize);
            this.PositionAndSize.Location = new System.Drawing.Point(550, 13);
            this.PositionAndSize.Name = "PositionAndSize";
            this.PositionAndSize.Size = new System.Drawing.Size(218, 114);
            this.PositionAndSize.TabIndex = 2;
            this.PositionAndSize.TabStop = false;
            this.PositionAndSize.Text = "Размеры и положение";
            // 
            // TextFrameSize
            // 
            this.TextFrameSize.Location = new System.Drawing.Point(123, 27);
            this.TextFrameSize.Name = "TextFrameSize";
            this.TextFrameSize.Size = new System.Drawing.Size(95, 23);
            this.TextFrameSize.TabIndex = 3;
            this.TextFrameSize.Text = "Размер текста";
            this.TextFrameSize.UseVisualStyleBackColor = true;
            this.TextFrameSize.Click += new System.EventHandler(this.TextFrameSize_Click);
            // 
            // AutoShapeSize
            // 
            this.AutoShapeSize.Location = new System.Drawing.Point(6, 54);
            this.AutoShapeSize.Name = "AutoShapeSize";
            this.AutoShapeSize.Size = new System.Drawing.Size(105, 23);
            this.AutoShapeSize.TabIndex = 2;
            this.AutoShapeSize.Text = "Размер фигур";
            this.AutoShapeSize.UseVisualStyleBackColor = true;
            this.AutoShapeSize.Click += new System.EventHandler(this.AutoShapeSize_Click);
            // 
            // ApplyPosition
            // 
            this.ApplyPosition.Location = new System.Drawing.Point(6, 80);
            this.ApplyPosition.Name = "ApplyPosition";
            this.ApplyPosition.Size = new System.Drawing.Size(105, 23);
            this.ApplyPosition.TabIndex = 1;
            this.ApplyPosition.Text = "Положение";
            this.ApplyPosition.UseVisualStyleBackColor = true;
            this.ApplyPosition.Click += new System.EventHandler(this.ApplyPosition_Click);
            // 
            // PictureSize
            // 
            this.PictureSize.Location = new System.Drawing.Point(7, 27);
            this.PictureSize.Name = "PictureSize";
            this.PictureSize.Size = new System.Drawing.Size(104, 23);
            this.PictureSize.TabIndex = 0;
            this.PictureSize.Text = "Размер рисунков";
            this.PictureSize.UseVisualStyleBackColor = true;
            this.PictureSize.Click += new System.EventHandler(this.ApplySize_Click);
            // 
            // EditToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 139);
            this.Controls.Add(this.PositionAndSize);
            this.Controls.Add(this.FiguresSection);
            this.Controls.Add(this.FontSection);
            this.MaximumSize = new System.Drawing.Size(796, 178);
            this.MinimumSize = new System.Drawing.Size(796, 178);
            this.Name = "EditToolsForm";
            this.Text = "Изменение всех элементов";
            this.FontSection.ResumeLayout(false);
            this.FontSection.PerformLayout();
            this.FiguresSection.ResumeLayout(false);
            this.FiguresSection.PerformLayout();
            this.PositionAndSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FontSection;
        private System.Windows.Forms.GroupBox FiguresSection;
        private System.Windows.Forms.GroupBox PositionAndSize;
        private System.Windows.Forms.Button MakeBoldButton;
        private System.Windows.Forms.Button FontColorButton;
        private System.Windows.Forms.Button MakeUnderlineButton;
        private System.Windows.Forms.Button MakeItalicButton;
        private System.Windows.Forms.Button MakeStrikeButton;
        private System.Windows.Forms.ComboBox ListOfFonts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FontSizeTextBox;
        private System.Windows.Forms.Button UnformatTextButton;
        private System.Windows.Forms.Button ShapeColorButton;
        private System.Windows.Forms.Button ForeColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LineWidth;
        private System.Windows.Forms.Button ApplyChoosenShapeFormat;
        private System.Windows.Forms.Button ApplyPosition;
        private System.Windows.Forms.Button PictureSize;
        private System.Windows.Forms.Button TextFrameSize;
        private System.Windows.Forms.Button AutoShapeSize;
        private System.Windows.Forms.Button buttonFontSizeOK;
    }
}