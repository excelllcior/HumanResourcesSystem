namespace HumanResourcesSystem.Views
{
    partial class PositionView
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonRemovePosition = new System.Windows.Forms.Button();
            this.buttonEditPosition = new System.Windows.Forms.Button();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelEditForm = new System.Windows.Forms.Panel();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.panelEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 13);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(79, 16);
            this.labelHeader.TabIndex = 43;
            this.labelHeader.Text = "Должности";
            // 
            // buttonRemovePosition
            // 
            this.buttonRemovePosition.Location = new System.Drawing.Point(396, 123);
            this.buttonRemovePosition.Name = "buttonRemovePosition";
            this.buttonRemovePosition.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePosition.TabIndex = 41;
            this.buttonRemovePosition.Text = "Удалить";
            this.buttonRemovePosition.UseVisualStyleBackColor = true;
            // 
            // buttonEditPosition
            // 
            this.buttonEditPosition.Location = new System.Drawing.Point(396, 65);
            this.buttonEditPosition.Name = "buttonEditPosition";
            this.buttonEditPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPosition.TabIndex = 40;
            this.buttonEditPosition.Text = "Изменить";
            this.buttonEditPosition.UseVisualStyleBackColor = true;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(396, 36);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPosition.TabIndex = 39;
            this.buttonAddPosition.Text = "Добавить";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(204, 130);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(12, 28);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(348, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(285, 130);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // panelEditForm
            // 
            this.panelEditForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEditForm.Controls.Add(this.labelSalary);
            this.panelEditForm.Controls.Add(this.labelName);
            this.panelEditForm.Controls.Add(this.buttonCancel);
            this.panelEditForm.Controls.Add(this.textBoxSalary);
            this.panelEditForm.Controls.Add(this.textBoxName);
            this.panelEditForm.Controls.Add(this.buttonOK);
            this.panelEditForm.Location = new System.Drawing.Point(16, 36);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Padding = new System.Windows.Forms.Padding(6);
            this.panelEditForm.Size = new System.Drawing.Size(376, 166);
            this.panelEditForm.TabIndex = 42;
            this.panelEditForm.Visible = false;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(9, 57);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(84, 13);
            this.labelSalary.TabIndex = 33;
            this.labelSalary.Text = "Зарплата (руб.)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Наименование";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSalary.Location = new System.Drawing.Point(12, 73);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(348, 20);
            this.textBoxSalary.TabIndex = 1;
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Location = new System.Drawing.Point(16, 36);
            this.dataGridViewPositions.MultiSelect = false;
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.ReadOnly = true;
            this.dataGridViewPositions.RowHeadersVisible = false;
            this.dataGridViewPositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPositions.Size = new System.Drawing.Size(374, 410);
            this.dataGridViewPositions.TabIndex = 38;
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 463);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonRemovePosition);
            this.Controls.Add(this.buttonEditPosition);
            this.Controls.Add(this.buttonAddPosition);
            this.Controls.Add(this.panelEditForm);
            this.Controls.Add(this.dataGridViewPositions);
            this.Name = "PositionView";
            this.Text = "Справочник «Должности»";
            this.panelEditForm.ResumeLayout(false);
            this.panelEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonRemovePosition;
        private System.Windows.Forms.Button buttonEditPosition;
        private System.Windows.Forms.Button buttonAddPosition;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelEditForm;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.DataGridView dataGridViewPositions;
    }
}