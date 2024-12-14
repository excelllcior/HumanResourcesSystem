using System;
using System.Data;
using System.Windows.Forms;
using HumanResourcesSystem.Properties;

namespace HumanResourcesSystem.Views
{
    public partial class LevelView : Form, ILevelView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;

        public int SelectedLevelId
        {
            get
            {
                int selectedLevelId = 0;

                if (dataGridViewLevels.Rows.Count > 0)
                {
                    int selectedRowIndex = dataGridViewLevels.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewLevels.Rows[selectedRowIndex];
                    selectedLevelId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                }

                return selectedLevelId;
            }
        }

        public string LevelName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public string SalaryCoefficient
        {
            get { return textBoxSalaryCoefficient.Text; }
            set { textBoxSalaryCoefficient.Text = value; }
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

        public event EventHandler AddLevelEvent;
        public event EventHandler EditLevelEvent;
        public event EventHandler RemoveLevelEvent;
        public event EventHandler SaveChangesEvent;
        public event EventHandler CancelChangesEvent;
        public event EventHandler LevelSelectedEvent;

        public LevelView()
        {
            InitializeComponent();
            AssociateControlEventsWithViewEvents();
        }

        private void AssociateControlEventsWithViewEvents()
        {
            buttonAddLevel.Click += ButtonAddLevelClicked;
            buttonEditLevel.Click += ButtonEditLevelClicked;
            buttonRemoveLevel.Click += ButtonRemoveLevelClicked;
            buttonOK.Click += ButtonOKClicked;
            buttonCancel.Click += ButtonCancelClicked;
            dataGridViewLevels.CellDoubleClick += DataGridViewLevelsCellDoubleClicked;
        }

        private void ButtonAddLevelClicked(object sender, EventArgs e)
        {
            dataGridViewLevels.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            AddLevelEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEditLevelClicked(object sender, EventArgs e)
        {
            if (SelectedLevelId == 0)
            {
                MessageBox.Show(
                    Resources.WarningSelectEntryToUpdate, Resources.CaptionUpdate,
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                return;
            }

            dataGridViewLevels.Visible = false;
            panelEditForm.Visible = true;
            ToggleActionButtons(false);

            EditLevelEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonRemoveLevelClicked(object sender, EventArgs e)
        {
            if (SelectedLevelId == 0)
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
                    RemoveLevelEvent?.Invoke(this, EventArgs.Empty);

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
                    dataGridViewLevels.Visible = true;
                    panelEditForm.Visible = false;
                    ToggleActionButtons(true);

                    if (!isEdit && dataGridViewLevels.Rows.Count > 0)
                    {
                        dataGridViewLevels.Rows[dataGridViewLevels.RowCount - 1].Selected = true;
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
            dataGridViewLevels.Visible = true;
            panelEditForm.Visible = false;
            ToggleActionButtons(true);

            CancelChangesEvent?.Invoke(this, EventArgs.Empty);
        }

        private void DataGridViewLevelsCellDoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            LevelSelectedEvent?.Invoke(this, EventArgs.Empty);
        }

        public void FillDataGridViewLevels(DataTable levelDataTable)
        {
            dataGridViewLevels.DataSource = levelDataTable;
        }

        private void ToggleActionButtons(bool enabled)
        {
            buttonAddLevel.Enabled = enabled;
            buttonEditLevel.Enabled = enabled;
            buttonRemoveLevel.Enabled = enabled;
        }
    }
}
