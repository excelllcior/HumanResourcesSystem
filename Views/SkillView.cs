using System;
using System.Data;
using System.Windows.Forms;
using HumanResourcesSystem.Properties;

namespace HumanResourcesSystem.Views
{
    public partial class SkillView : Form, ISkillView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public int SelectedSkillId
        {
            get
            {
                int selectedSkillId = 0;

                if (dataGridViewSkills.Rows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewSkills.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewSkills.Rows[selectedRowIndex];
                    selectedSkillId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }

                return selectedSkillId;
            }
        }

        public string SkillName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public bool IsEdit 
        { 
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful 
        { 
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message 
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler AddSkillEvent;
        public event EventHandler EditSkillEvent;
        public event EventHandler RemoveSkillEvent;
        public event EventHandler SaveChangesEvent;
        public event EventHandler CancelChangesEvent;
        public event EventHandler SkillSelectedEvent;

        public SkillView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        private void AssociateControlEventsWithViewEvents()
        {
            buttonAddSkill.Click += ButtonAddSkillClicked;
            buttonEditSkill.Click += ButtonEditSkillClicked;
            buttonRemoveSkill.Click += ButtonRemoveSkillClicked;
            buttonOK.Click += ButtonOKClicked;
            buttonCancel.Click += ButtonCancelClicked;
            dataGridViewSkills.CellDoubleClick += DataGridViewSkillsCellDoubleClicked;
        }

        private void ButtonAddSkillClicked(object sender, EventArgs e)
        {
            dataGridViewSkills.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            AddSkillEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEditSkillClicked(object sender, EventArgs e)
        {
            if (SelectedSkillId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToUpdate, Resources.CaptionUpdate,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            dataGridViewSkills.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            EditSkillEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonRemoveSkillClicked(object sender, EventArgs e)
        {
            if (SelectedSkillId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToDelete, Resources.CaptionDelete,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                Resources.WarningConfirmDelete, Resources.CaptionDelete,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    RemoveSkillEvent?.Invoke(this, EventArgs.Empty);

                    MessageBox.Show(
                        Message, Resources.CaptionDelete,
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void ButtonOKClicked(object sender, EventArgs e)
        {
            SaveChangesEvent?.Invoke(this, EventArgs.Empty);

            string caption;
            if (isEdit)
            {
                caption = Resources.CaptionUpdate;
            }
            else
            {
                caption = Resources.CaptionInsert;
            }

            switch (isSuccessful)
            {
                case true:
                    dataGridViewSkills.Visible = true;
                    panelEditForm.Visible = false;
                    ToggleActionButtons(true);

                    if (!isEdit && dataGridViewSkills.Rows.Count > 0)
                    {
                        dataGridViewSkills.Rows[dataGridViewSkills.RowCount - 1].Selected = true;
                    }

                    MessageBox.Show(
                        Message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                    break;

                case false:
                    MessageBox.Show(
                        Message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );

                    break;
            }
        }

        private void ButtonCancelClicked(object sender, EventArgs e)
        {
            dataGridViewSkills.Visible = true;
            panelEditForm.Visible = false;
            ToggleActionButtons(true);

            CancelChangesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void DataGridViewSkillsCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            SkillSelectedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void FillDataGridViewSkills(DataTable skillDataTable)
        {
            dataGridViewSkills.DataSource = skillDataTable;
        }

        private void ToggleActionButtons(bool enabled)
        {
            buttonAddSkill.Enabled = enabled;
            buttonEditSkill.Enabled = enabled;
            buttonRemoveSkill.Enabled = enabled;
        }
    }
}
