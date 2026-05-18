using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ind_project_project.Core;

namespace ind_project_project.UI
{
    public partial class SettingsTabContent : TabContent
    {
        public SettingsTabContent()
        {
            InitializeComponent();
        }

        private void SettingsTabContent_Load(object sender, EventArgs e)
        {
            entryMinWage.Value = (decimal)ConfigManager.Instance.Get<double>("MinimumWage");
            entryNonTaxable.Value = (decimal)ConfigManager.Instance.Get<double>("NonTaxableMinimum");
            estimatedTaxRate.Value = (decimal)ConfigManager.Instance.Get<double>("EstimatedTaxRate") * 100;
            hourlyRate.Value = (decimal)ConfigManager.Instance.Get<double>("DefaultHourlyRate");
        }

        private void entryNonTaxable_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            ConfigManager.Instance.Set("NonTaxableMinimum", (double)senderControl.Value);
        }

        private void estimatedTaxRate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            ConfigManager.Instance.Set("EstimatedTaxRate", (double)senderControl.Value / 100);
        }

        private void hourlyRate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            ConfigManager.Instance.Set("DefaultHourlyRate", (double)senderControl.Value);
        }

        private void entryMinWage_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            ConfigManager.Instance.Set("MinimumWage", (double)senderControl.Value);
        }
    }
}
