using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IvanovDDBPI182
{
    public partial class AddGroupForm : Form
    {
        private Dictionary<string, Group> existingGroups;
        private Group groupToAdd;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupForm"/> class.
        /// </summary>
        /// <param name="existingGroups">The existing groups.</param>
        /// <param name="groupToAdd">The group to add.</param>
        public AddGroupForm(Dictionary<string, Group> existingGroups, Group groupToAdd)
        {
            this.existingGroups = existingGroups;
            this.groupToAdd = groupToAdd;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the OKButton control, sets the name of new group.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (name.Length > 20 || name.Length < 4)
            {
                MessageBox.Show("Имя группы должно состоять из не менее чем 4 и не более чем из 20 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (name.Contains(" "))
            {
                MessageBox.Show("Имя группы не может содержать пробелов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var bannedname in existingGroups.Keys)
                if (bannedname == name)
                {
                    MessageBox.Show("Слой с таким именем уже существует.\nПридумайте другое имя или удлалите существующмй слой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameTextBox.Text = "";
                    return;
                }
            existingGroups.Add(name, groupToAdd);
            MessageBox.Show($"Группа {name} была успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
