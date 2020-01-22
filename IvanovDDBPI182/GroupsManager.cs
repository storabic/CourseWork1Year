using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace IvanovDDBPI182
{
    public partial class GroupsManager : Form
    {
        /// <summary>
        /// All groups.
        /// </summary>
        /// <value>
        /// The groups.
        /// </value>
        public Dictionary<string, Group> Groups { set; get; }

        /// <summary>
        /// The current group name
        /// </summary>
        private string currentGroupName;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsManager"/> class.
        /// </summary>
        /// <param name="currentGroups">The current groups.</param>
        public GroupsManager(Dictionary<String, Group> currentGroups)
        {
            InitializeComponent();
            Groups = currentGroups;
            UpdateListOfGroups();
            ShowControlButtons(false);
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listOfGroups control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void listOfGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfGroups.Text.Length != 0)
            {
                try
                {
                    ShowControlButtons(true);
                    currentGroupName = listOfGroups.Text;
                }
                catch
                {

                }
            }
            else
            {
                ShowControlButtons(false);
            }
        }

        /// <summary>
        /// Updates the list of groups.
        /// </summary>
        private void UpdateListOfGroups()
        {
            listOfGroups.Items.Clear();
            listOfGroups.Items.AddRange(Groups.Keys.ToArray());
        }

        /// <summary>
        /// Shows the control buttons.
        /// </summary>
        /// <param name="flag">if flag = true shows control buttons, if flag = false hides them.</param>
        private void ShowControlButtons(bool flag)
        {
            AddToGroupButton.Enabled = flag;
            DeleteGroupButton.Enabled = flag;
            DeleteGroupAndContentButton.Enabled = flag;
            ShowTypesButton.Enabled = flag;
            button1.Enabled = flag;
        }

        /// <summary>
        /// Handles the Click event of the ShowTypesButton control and shows types of elems in group
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ShowTypesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Groups[currentGroupName].ReturnTypes(), $"Типы объектов в группе {currentGroupName}", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Handles the Click event of the DeleteGroupButton control, deletes group
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            Groups[currentGroupName] = new Group();
            listOfGroups.Items.Remove(listOfGroups.Text);
            listOfGroups.Text = "";
            ShowControlButtons(false);
        }

        /// <summary>
        /// Handles the Click event of the DeleteGroupAndContentButton controlm deletes group and its content
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DeleteGroupAndContentButton_Click(object sender, EventArgs e)
        {
            Groups[currentGroupName].DeleteContent();

            listOfGroups.Items.Remove(listOfGroups.Text);
            listOfGroups.Text = "";
            ShowControlButtons(false);
        }

        /// <summary>
        /// Handles the Click event of the AddGroupButton control, adds group
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            if (Groups.Count > 20)
            {
                MessageBox.Show("Нельзя создать больше чем 20 групп", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
            }
            catch
            {
                MessageBox.Show("Не найдено выбранных объектов слайда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Shape shape in selectedShapes)
            {
                if (shape.Type == Office.MsoShapeType.msoPlaceholder)
                {
                    MessageBox.Show("К сожалению, в группу нельзя добавить предмет типа \"объект\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Group groupToAdd = new Group(selectedShapes);
            AddGroupForm addGroupForm = new AddGroupForm(Groups, groupToAdd);
            //MakeFakeSlide(selectedShapes);
            addGroupForm.ShowDialog();
            UpdateListOfGroups();
        }

        /// <summary>
        /// Handles the Click event of the AddToGroupButton control, adds shaperange to group
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void AddToGroupButton_Click(object sender, EventArgs e)
        {
            ShapeRange selectedShapes;
            try
            {
                selectedShapes = Globals.ThisAddIn.Application.ActiveWindow.Selection.ShapeRange;
            }
            catch
            {
                MessageBox.Show("Не найдено выбранных объектов слайда", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Shape shape in selectedShapes)
            {
                if (shape.Type == Office.MsoShapeType.msoPlaceholder)
                {
                    MessageBox.Show("К сожалению, в группу нельзя добавить предмет типа \"объект\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Groups[currentGroupName].Add(selectedShapes);
            Groups[currentGroupName].SelectAll();
        }

        /// <summary>
        /// Handles the Click event of the button1 control and launches Edit Tools 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            EditToolsForm editTools = new EditToolsForm(Groups[currentGroupName]);
            editTools.Show();
        }
    }
}