using ind_project_project.core;
using ind_project_project.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ind_project_project.ui_elements
{
    public partial class DashboardTabContent : TabContent
    {
        public DashboardTabContent()
        {
            InitializeComponent();
        }

        internal TimeWorkSession CreateTimeBasedSession(int hours, int minutes = 0)
        {
            TimeWorkSession session = new TimeWorkSession(hours, minutes, (float)ConfigManager.Instance.Get<double>("DefaultHourlyRate"));
            return session;
        }

        internal FixedPriceWork CreateFixedPriceWork(float price)
        {
            FixedPriceWork session = new FixedPriceWork(price);
            return session;
        }

        internal void AddHistoryRecord(string text, float sum)
        {
            int formPadding = flowHistory.Padding.Left;

            DashboardHistoryRecord form = new DashboardHistoryRecord();
            form.lblText.Text = text;
            form.lblAmount.Text = $"{sum:F2} EUR";
            form.Parent = flowHistory;
            form.Dock = DockStyle.Top;
            form.Width = flowHistory.Width - formPadding * 2;
        }

        private void timeInvoiceCreate_Click(object sender, EventArgs e)
        {
            int hours = (int)hourAmtEntry.Value;
            int minutes = (int)minAmtEntry.Value;

            if (hours < 1 && minutes < 1)
            {
                if (lblHoursHelp.Tag is null)
                {
                    lblHoursHelp.Tag = lblHoursHelp.Text;
                }
                lblHoursHelp.Text = "Please input time!";
                lblHoursHelp.ForeColor = Color.Red;
                return;
            }
            else if (lblHoursHelp.Tag is not null)
            {
                lblHoursHelp.Text = (string)lblHoursHelp.Tag;
                lblHoursHelp.ForeColor = Color.Black;
                lblHoursHelp.Tag = null;
            }

            TimeWorkSession session = CreateTimeBasedSession(hours, minutes);

            float sum = session.GetGrossIncome();

            AddHistoryRecord(session.GetDescText(), sum);

            Database.Instance.AddRecord(session);
        }

        private void fixedInvoiceCreate_Click(object sender, EventArgs e)
        {
            float sum = (float)fixedAmtEntry.Value;

            if (sum < 1)
            {
                if (lblHoursHelp.Tag is null)
                {
                    lblHoursHelp.Tag = lblHoursHelp.Text;
                }
                lblHoursHelp.Text = "Please input sum!";
                lblHoursHelp.ForeColor = Color.Red;
                return;
            }
            else if (lblHoursHelp.Tag is not null)
            {
                lblHoursHelp.Text = (string)lblHoursHelp.Tag;
                lblHoursHelp.ForeColor = Color.Black;
                lblHoursHelp.Tag = null;
            }

            FixedPriceWork session = CreateFixedPriceWork(sum);
            AddHistoryRecord(session.GetDescText(), sum);
            Database.Instance.AddRecord(session);
        }
    }
}
