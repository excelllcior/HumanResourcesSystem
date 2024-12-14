namespace HumanResourcesSystem
{
    partial class MainView
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripCatalogs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCatalogsEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCatalogsPositions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCatalogsSkills = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCatalogsLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCatalogsProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCatalogs,
            this.toolStripReports});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "Главное меню";
            // 
            // toolStripCatalogs
            // 
            this.toolStripCatalogs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCatalogsEmployees,
            this.toolStripCatalogsPositions,
            this.toolStripCatalogsSkills,
            this.toolStripCatalogsLevels,
            this.toolStripCatalogsProjects});
            this.toolStripCatalogs.Name = "toolStripCatalogs";
            this.toolStripCatalogs.Size = new System.Drawing.Size(94, 20);
            this.toolStripCatalogs.Text = "Справочники";
            // 
            // toolStripCatalogsEmployees
            // 
            this.toolStripCatalogsEmployees.Name = "toolStripCatalogsEmployees";
            this.toolStripCatalogsEmployees.Size = new System.Drawing.Size(180, 22);
            this.toolStripCatalogsEmployees.Text = "Сотрудники";
            // 
            // toolStripCatalogsPositions
            // 
            this.toolStripCatalogsPositions.Name = "toolStripCatalogsPositions";
            this.toolStripCatalogsPositions.Size = new System.Drawing.Size(180, 22);
            this.toolStripCatalogsPositions.Text = "Должности";
            // 
            // toolStripReports
            // 
            this.toolStripReports.Name = "toolStripReports";
            this.toolStripReports.Size = new System.Drawing.Size(60, 20);
            this.toolStripReports.Text = "Отчёты";
            // 
            // toolStripCatalogsSkills
            // 
            this.toolStripCatalogsSkills.Name = "toolStripCatalogsSkills";
            this.toolStripCatalogsSkills.Size = new System.Drawing.Size(180, 22);
            this.toolStripCatalogsSkills.Text = "Навыки";
            // 
            // toolStripCatalogsLevels
            // 
            this.toolStripCatalogsLevels.Name = "toolStripCatalogsLevels";
            this.toolStripCatalogsLevels.Size = new System.Drawing.Size(180, 22);
            this.toolStripCatalogsLevels.Text = "Уровни";
            // 
            // toolStripCatalogsProjects
            // 
            this.toolStripCatalogsProjects.Name = "toolStripCatalogsProjects";
            this.toolStripCatalogsProjects.Size = new System.Drawing.Size(180, 22);
            this.toolStripCatalogsProjects.Text = "Проекты";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainView";
            this.Text = "Главная";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogs;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogsEmployees;
        private System.Windows.Forms.ToolStripMenuItem toolStripReports;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogsPositions;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogsSkills;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogsLevels;
        private System.Windows.Forms.ToolStripMenuItem toolStripCatalogsProjects;
    }
}

