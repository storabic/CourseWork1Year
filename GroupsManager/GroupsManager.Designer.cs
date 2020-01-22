namespace GroupsManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfGroups = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.DeleteGroupAndContentButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfGroups
            // 
            this.listOfGroups.FormattingEnabled = true;
            this.listOfGroups.Location = new System.Drawing.Point(13, 39);
            this.listOfGroups.Name = "listOfGroups";
            this.listOfGroups.Size = new System.Drawing.Size(121, 21);
            this.listOfGroups.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Группы";
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(12, 107);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(140, 23);
            this.AddGroupButton.TabIndex = 2;
            this.AddGroupButton.Text = "Добавить новую группу";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // DeleteGroupAndContentButton
            // 
            this.DeleteGroupAndContentButton.Location = new System.Drawing.Point(15, 227);
            this.DeleteGroupAndContentButton.Name = "DeleteGroupAndContentButton";
            this.DeleteGroupAndContentButton.Size = new System.Drawing.Size(191, 23);
            this.DeleteGroupAndContentButton.TabIndex = 3;
            this.DeleteGroupAndContentButton.Text = "Удалить группу и всё содержимое";
            this.DeleteGroupAndContentButton.UseVisualStyleBackColor = true;
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Location = new System.Drawing.Point(15, 198);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(119, 23);
            this.DeleteGroupButton.TabIndex = 4;
            this.DeleteGroupButton.Text = "Удалить группу";
            this.DeleteGroupButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.DeleteGroupAndContentButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listOfGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Button DeleteGroupAndContentButton;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Button button4;
    }
}

