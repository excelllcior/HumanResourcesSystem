namespace HumanResourcesSystem.Views
{
    partial class LevelView
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
            this.buttonRemoveLevel = new System.Windows.Forms.Button();
            this.buttonEditLevel = new System.Windows.Forms.Button();
            this.buttonAddLevel = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelEditForm = new System.Windows.Forms.Panel();
            this.labelSalaryCoefficient = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSalaryCoefficient = new System.Windows.Forms.TextBox();
            this.dataGridViewLevels = new System.Windows.Forms.DataGridView();
            this.panelEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 13);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(56, 16);
            this.labelHeader.TabIndex = 49;
            this.labelHeader.Text = "Уровни";
            // 
            // buttonRemoveLevel
            // 
            this.buttonRemoveLevel.Location = new System.Drawing.Point(396, 123);
            this.buttonRemoveLevel.Name = "buttonRemoveLevel";
            this.buttonRemoveLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveLevel.TabIndex = 47;
            this.buttonRemoveLevel.Text = "Удалить";
            this.buttonRemoveLevel.UseVisualStyleBackColor = true;
            // 
            // buttonEditLevel
            // 
            this.buttonEditLevel.Location = new System.Drawing.Point(396, 65);
            this.buttonEditLevel.Name = "buttonEditLevel";
            this.buttonEditLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonEditLevel.TabIndex = 46;
            this.buttonEditLevel.Text = "Изменить";
            this.buttonEditLevel.UseVisualStyleBackColor = true;
            // 
            // buttonAddLevel
            // 
            this.buttonAddLevel.Location = new System.Drawing.Point(396, 36);
            this.buttonAddLevel.Name = "buttonAddLevel";
            this.buttonAddLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLevel.TabIndex = 45;
            this.buttonAddLevel.Text = "Добавить";
            this.buttonAddLevel.UseVisualStyleBackColor = true;
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
            this.panelEditForm.Controls.Add(this.labelSalaryCoefficient);
            this.panelEditForm.Controls.Add(this.labelName);
            this.panelEditForm.Controls.Add(this.buttonCancel);
            this.panelEditForm.Controls.Add(this.textBoxSalaryCoefficient);
            this.panelEditForm.Controls.Add(this.textBoxName);
            this.panelEditForm.Controls.Add(this.buttonOK);
            this.panelEditForm.Location = new System.Drawing.Point(16, 36);
            this.panelEditForm.Name = "panelEditForm";
            this.panelEditForm.Padding = new System.Windows.Forms.Padding(6);
            this.panelEditForm.Size = new System.Drawing.Size(376, 166);
            this.panelEditForm.TabIndex = 48;
            this.panelEditForm.Visible = false;
            // 
            // labelSalaryCoefficient
            // 
            this.labelSalaryCoefficient.AutoSize = true;
            this.labelSalaryCoefficient.Location = new System.Drawing.Point(9, 57);
            this.labelSalaryCoefficient.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.labelSalaryCoefficient.Name = "labelSalaryCoefficient";
            this.labelSalaryCoefficient.Size = new System.Drawing.Size(77, 13);
            this.labelSalaryCoefficient.TabIndex = 33;
            this.labelSalaryCoefficient.Text = "Коэффициент";
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
            // textBoxSalaryCoefficient
            // 
            this.textBoxSalaryCoefficient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSalaryCoefficient.Location = new System.Drawing.Point(12, 73);
            this.textBoxSalaryCoefficient.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxSalaryCoefficient.Name = "textBoxSalaryCoefficient";
            this.textBoxSalaryCoefficient.Size = new System.Drawing.Size(348, 20);
            this.textBoxSalaryCoefficient.TabIndex = 1;
            // 
            // dataGridViewLevels
            // 
            this.dataGridViewLevels.AllowUserToAddRows = false;
            this.dataGridViewLevels.AllowUserToDeleteRows = false;
            this.dataGridViewLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLevels.Location = new System.Drawing.Point(16, 36);
            this.dataGridViewLevels.MultiSelect = false;
            this.dataGridViewLevels.Name = "dataGridViewLevels";
            this.dataGridViewLevels.ReadOnly = true;
            this.dataGridViewLevels.RowHeadersVisible = false;
            this.dataGridViewLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLevels.Size = new System.Drawing.Size(374, 410);
            this.dataGridViewLevels.TabIndex = 44;
            // 
            // LevelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 461);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.buttonRemoveLevel);
            this.Controls.Add(this.buttonEditLevel);
            this.Controls.Add(this.buttonAddLevel);
            this.Controls.Add(this.panelEditForm);
            this.Controls.Add(this.dataGridViewLevels);
            this.Name = "LevelView";
            this.Text = "Справочник «Уровни»";
            this.panelEditForm.ResumeLayout(false);
            this.panelEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLevels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonRemoveLevel;
        private System.Windows.Forms.Button buttonEditLevel;
        private System.Windows.Forms.Button buttonAddLevel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panelEditForm;
        private System.Windows.Forms.Label labelSalaryCoefficient;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSalaryCoefficient;
        private System.Windows.Forms.DataGridView dataGridViewLevels;
    }
}