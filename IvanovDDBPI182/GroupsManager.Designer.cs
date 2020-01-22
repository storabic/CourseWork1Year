namespace IvanovDDBPI182
{
    partial class GroupsManager
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
            this.ShowTypesButton = new System.Windows.Forms.Button();
            this.DeleteGroupButton = new System.Windows.Forms.Button();
            this.DeleteGroupAndContentButton = new System.Windows.Forms.Button();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfGroups = new System.Windows.Forms.ComboBox();
            this.AddToGroupButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowTypesButton
            // 
            this.ShowTypesButton.Location = new System.Drawing.Point(211, 120);
            this.ShowTypesButton.Name = "ShowTypesButton";
            this.ShowTypesButton.Size = new System.Drawing.Size(103, 23);
            this.ShowTypesButton.TabIndex = 11;
            this.ShowTypesButton.Text = "Типы объектов";
            this.ShowTypesButton.UseVisualStyleBackColor = true;
            this.ShowTypesButton.Click += new System.EventHandler(this.ShowTypesButton_Click);
            // 
            // DeleteGroupButton
            // 
            this.DeleteGroupButton.Location = new System.Drawing.Point(12, 91);
            this.DeleteGroupButton.Name = "DeleteGroupButton";
            this.DeleteGroupButton.Size = new System.Drawing.Size(142, 23);
            this.DeleteGroupButton.TabIndex = 10;
            this.DeleteGroupButton.Text = "Расформировать группу";
            this.DeleteGroupButton.UseVisualStyleBackColor = true;
            this.DeleteGroupButton.Click += new System.EventHandler(this.DeleteGroupButton_Click);
            // 
            // DeleteGroupAndContentButton
            // 
            this.DeleteGroupAndContentButton.Location = new System.Drawing.Point(12, 120);
            this.DeleteGroupAndContentButton.Name = "DeleteGroupAndContentButton";
            this.DeleteGroupAndContentButton.Size = new System.Drawing.Size(191, 23);
            this.DeleteGroupAndContentButton.TabIndex = 9;
            this.DeleteGroupAndContentButton.Text = "Удалить группу и всё содержимое";
            this.DeleteGroupAndContentButton.UseVisualStyleBackColor = true;
            this.DeleteGroupAndContentButton.Click += new System.EventHandler(this.DeleteGroupAndContentButton_Click);
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(174, 29);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(140, 23);
            this.AddGroupButton.TabIndex = 8;
            this.AddGroupButton.Text = "Добавить новую группу";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            this.AddGroupButton.Click += new System.EventHandler(this.AddGroupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Группы";
            // 
            // listOfGroups
            // 
            this.listOfGroups.FormattingEnabled = true;
            this.listOfGroups.Location = new System.Drawing.Point(12, 29);
            this.listOfGroups.Name = "listOfGroups";
            this.listOfGroups.Size = new System.Drawing.Size(121, 21);
            this.listOfGroups.TabIndex = 6;
            this.listOfGroups.SelectedIndexChanged += new System.EventHandler(this.listOfGroups_SelectedIndexChanged);
            // 
            // AddToGroupButton
            // 
            this.AddToGroupButton.Location = new System.Drawing.Point(174, 59);
            this.AddToGroupButton.Name = "AddToGroupButton";
            this.AddToGroupButton.Size = new System.Drawing.Size(137, 23);
            this.AddToGroupButton.TabIndex = 12;
            this.AddToGroupButton.Text = "Добавить в группу";
            this.AddToGroupButton.UseVisualStyleBackColor = true;
            this.AddToGroupButton.Click += new System.EventHandler(this.AddToGroupButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddToGroupButton);
            this.Controls.Add(this.ShowTypesButton);
            this.Controls.Add(this.DeleteGroupButton);
            this.Controls.Add(this.DeleteGroupAndContentButton);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfGroups);
            this.MaximumSize = new System.Drawing.Size(339, 194);
            this.MinimumSize = new System.Drawing.Size(339, 194);
            this.Name = "GroupsManager";
            this.Text = "Менеджер групп";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowTypesButton;
        private System.Windows.Forms.Button DeleteGroupButton;
        private System.Windows.Forms.Button DeleteGroupAndContentButton;
        private System.Windows.Forms.Button AddGroupButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listOfGroups;
        private System.Windows.Forms.Button AddToGroupButton;
        private System.Windows.Forms.Button button1;
    }
}