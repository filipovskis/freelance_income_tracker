using ind_project_project.Models;
using ind_project_project.UI;
using ind_project_project.Core;

namespace ind_project_project
{

    public partial class MainForm : Form
    {
        private TabContent ?lastPanel;
        private ToolStripMenuItem ?lastTab;

        partial void SetupDatabase();

        public MainForm()
        {
            InitializeComponent();
            SetupDatabase();
        }

        private void ToggleActiveTab(ToolStripMenuItem btnTab, bool state)
        {
            if (state)
            {
                btnTab.BackColor = Color.FromArgb(200, 200, 255);
            }
            else
            {
                btnTab.BackColor = SystemColors.ActiveBorder;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lastPanel = dashboardTabContent1;
            lastTab = mainTab;
            ToggleActiveTab(mainTab, true);
        }

        private void SwitchToTab(ToolStripMenuItem btnTab, TabContent targetPnlContent)
        {
            if (lastPanel != null) lastPanel.Hide();

            if (lastTab != null) ToggleActiveTab(lastTab, false);

            lastPanel = targetPnlContent;
            lastTab = btnTab;

            targetPnlContent.BringToFront();
            targetPnlContent.Show();
            targetPnlContent.OnActivated();

            ToggleActiveTab(btnTab, true);
        }

        private void mainTab_Click(object sender, EventArgs e)
        {
            SwitchToTab(mainTab,dashboardTabContent1);
        }

        private void recordsTab_Click(object sender, EventArgs e)
        {
            SwitchToTab(recordsTab, recordsTabContent1);
        }

        private void settingsTab_Click(object sender, EventArgs e)
        {
            SwitchToTab(settingsTab, settingsTabContent1);
        }
    }
}
