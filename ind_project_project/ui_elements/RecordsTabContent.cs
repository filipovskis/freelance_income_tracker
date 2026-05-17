using ind_project_project.core;
using ind_project_project.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ind_project_project.ui_elements
{
    public partial class RecordsTabContent : TabContent
    {
        public RecordsTabContent()
        {
            InitializeComponent();
            Database.Instance.DatabaseWiped += (sender, args) => PopulateRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public override void OnActivated()
        {
            PopulateRecords();
        }

        public void PopulateRecords()
        {
            dataGrid.Rows.Clear();

            List<BaseRecord> test = Database.Instance.GetRecords();
            Console.Write(test);
            foreach (var record in test)
            {
                double grossIncome = record.GetGrossIncome();
                double estimatedTax = record.GetEstimatedTax();
                double income = grossIncome - estimatedTax;
                int index = dataGrid.Rows.Add(record.Date.ToString(), Math.Round(grossIncome, 2), Math.Round(estimatedTax, 2), Math.Round(income, 2));
                dataGrid.Rows[index].Tag = record;
            }
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            PopulateRecords();
        }

        private string formatMoney(double amount)
        {
            return Math.Round(amount, 2).ToString() + "€";
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            WorkPeriod period = new WorkPeriod();

            foreach (DataGridViewRow row in view.Rows)
            {
                if (row != null && row.Selected)
                {
                    period.AddRecord((BaseRecord)row.Tag);
                }
            }

            double vsaoi = period.CalculateVSAOI();
            double iin = period.CalculateIIN();
            double totalTax = vsaoi + iin;
            double sum = period.CalculateSum();
            double profit = sum - totalTax;

            lblNetto.Text = formatMoney(profit);
            lblTotalIncome.Text = formatMoney(sum);
            lblTotalTax.Text = formatMoney(totalTax);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            dataGrid.SelectAll();
        }

        internal void btnWipe_Click(object sender, EventArgs e)
        {
            FormConfirmWipe newForm = new FormConfirmWipe();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show();
            //int x0 = 
            //newForm.Location = new Point();
        }

        private void dataGrid_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            //e.Column.Dispose();
        }

        private void dataGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            // discovered new way to check
            if (e.Row.Tag is BaseRecord record)
            {
                Database.Instance.DeleteRecord(record.ID);
            }
        }

        private void StartRowEdit(DataGridViewRow row)
        {
            BaseRecord? record = row.Tag as BaseRecord;
            if (record != null)
            {
                EditRecord form = new EditRecord(record);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
                form.RecordEdited += (sender, args) => PopulateRecords();
            }
        }

        private void dataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StartRowEdit(dataGrid.Rows[e.RowIndex]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow firstSelected = dataGrid.SelectedRows[0];
            if (firstSelected != null)
            {
                StartRowEdit(firstSelected);
            }
        }
    }
}
