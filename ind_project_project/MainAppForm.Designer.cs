namespace ind_project_project
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navbar = new MenuStrip();
            mainTab = new ToolStripMenuItem();
            recordsTab = new ToolStripMenuItem();
            settingsTab = new ToolStripMenuItem();
            panel1 = new Panel();
            recordsTabContent1 = new ind_project_project.ui_elements.RecordsTabContent();
            dashboardTabContent1 = new ind_project_project.ui_elements.DashboardTabContent();
            settingsTabContent1 = new ind_project_project.ui_elements.SettingsTabContent();
            navbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = SystemColors.ActiveBorder;
            navbar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            navbar.Items.AddRange(new ToolStripItem[] { mainTab, recordsTab, settingsTab });
            navbar.Location = new Point(0, 0);
            navbar.MinimumSize = new Size(0, 50);
            navbar.Name = "navbar";
            navbar.Size = new Size(1215, 50);
            navbar.TabIndex = 0;
            navbar.Text = "menuStrip1";
            // 
            // mainTab
            // 
            mainTab.Image = Properties.Resources.dashboard_1_;
            mainTab.Name = "mainTab";
            mainTab.Size = new Size(121, 46);
            mainTab.Text = "Dashboard";
            mainTab.Click += mainTab_Click;
            // 
            // recordsTab
            // 
            recordsTab.Image = Properties.Resources.list;
            recordsTab.Name = "recordsTab";
            recordsTab.Size = new Size(98, 46);
            recordsTab.Text = "Records";
            recordsTab.Click += recordsTab_Click;
            // 
            // settingsTab
            // 
            settingsTab.BackColor = SystemColors.ActiveBorder;
            settingsTab.Image = Properties.Resources.settings;
            settingsTab.Name = "settingsTab";
            settingsTab.Size = new Size(100, 46);
            settingsTab.Text = "Settings";
            settingsTab.Click += this.settingsTab_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(settingsTabContent1);
            panel1.Controls.Add(recordsTabContent1);
            panel1.Controls.Add(dashboardTabContent1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1215, 632);
            panel1.TabIndex = 1;
            // 
            // recordsTabContent1
            // 
            recordsTabContent1.Dock = DockStyle.Fill;
            recordsTabContent1.Location = new Point(10, 10);
            recordsTabContent1.Name = "recordsTabContent1";
            recordsTabContent1.Size = new Size(1195, 612);
            recordsTabContent1.TabIndex = 1;
            recordsTabContent1.Visible = false;
            // 
            // dashboardTabContent1
            // 
            dashboardTabContent1.BackColor = SystemColors.Control;
            dashboardTabContent1.Dock = DockStyle.Fill;
            dashboardTabContent1.Location = new Point(10, 10);
            dashboardTabContent1.Name = "dashboardTabContent1";
            dashboardTabContent1.Size = new Size(1195, 612);
            dashboardTabContent1.TabIndex = 0;
            // 
            // settingsTabContent1
            // 
            settingsTabContent1.Dock = DockStyle.Fill;
            settingsTabContent1.Location = new Point(10, 10);
            settingsTabContent1.Name = "settingsTabContent1";
            settingsTabContent1.Padding = new Padding(10);
            settingsTabContent1.Size = new Size(1195, 612);
            settingsTabContent1.TabIndex = 2;
            settingsTabContent1.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 682);
            Controls.Add(panel1);
            Controls.Add(navbar);
            MainMenuStrip = navbar;
            Name = "MainForm";
            Text = "Income Tax Management";
            Load += Form1_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip navbar;
        private ToolStripMenuItem mainTab;
        private ToolStripMenuItem recordsTab;
        private ToolStripMenuItem settingsTab;
        private Panel panel1;
        private ui_elements.DashboardTabContent dashboardTabContent1;
        private ui_elements.RecordsTabContent recordsTabContent1;
        private ui_elements.SettingsTabContent settingsTabContent1;
    }
}
