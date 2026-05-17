using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ind_project_project.ui_elements
{
    public partial class DashboardHistoryRecord : UserControl
    {
        public DashboardHistoryRecord()
        {
            InitializeComponent();
        }

        async void UpdateTextReturn(Button btn, string newText)
        {
            if (btn.Tag is null || (bool)btn.Tag == false)
            {
                string oldText = btn.Text;
                btn.Tag = true;
                btn.Text = newText;
                await Task.Delay(1000);
                btn.Text = oldText;
                btn.Tag = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // copy to clipboard
            Clipboard.SetText(lblText.Text);

            UpdateTextReturn(button1, "Copied!");
        }
    }
}
