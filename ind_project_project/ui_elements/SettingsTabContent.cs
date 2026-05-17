using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ind_project_project.ui_elements
{
    public partial class SettingsTabContent : TabContent
    {
        public SettingsTabContent()
        {
            InitializeComponent();
        }

        private void SettingsTabContent_Load(object sender, EventArgs e)
        {
            entryNonTaxable.Value = (decimal)core.ConfigManager.Instance.Get<double>("NonTaxableMinimum");
            estimatedTaxRate.Value = (decimal)core.ConfigManager.Instance.Get<double>("EstimatedTaxRate") * 100;
            hourlyRate.Value = (decimal)core.ConfigManager.Instance.Get<double>("DefaultHourlyRate");
        }

        private void entryNonTaxable_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            core.ConfigManager.Instance.Set("NonTaxableMinimum", (double)senderControl.Value);
        }

        private void estimatedTaxRate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            core.ConfigManager.Instance.Set("EstimatedTaxRate", (double)senderControl.Value / 100);
        }

        private void hourlyRate_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown senderControl = (NumericUpDown)sender;
            core.ConfigManager.Instance.Set("DefaultHourlyRate", (double)senderControl.Value);
        }
    }
}
