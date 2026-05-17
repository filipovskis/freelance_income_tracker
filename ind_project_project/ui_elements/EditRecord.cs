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
    public partial class EditRecord : Form
    {
        private BaseRecord _record;
        public EventHandler? RecordEdited;

        public EditRecord( BaseRecord record )
        {
            _record = record;
            InitializeComponent();
            LoadRecord(record);
        }

        private void LoadRecord(BaseRecord record)
        {
            entryDate.Value = record.Date;

            if ( record is TimeWorkSession timeRecord)
            {
                entryHourRate.Value = (decimal)timeRecord.HourRate;
                entryHours.Value = timeRecord.Hours;
                entryMinutes.Value = timeRecord.Minutes;

                divFixedSum.Visible = false;
            }
            else if (record is FixedPriceWork fixedRecord)
            {
                entryFixed.Value = (decimal)fixedRecord.Price;

                divHourRate.Visible = false;
                divHours.Visible = false;
                divMinutes.Visible = false;
            }
            else
            {
                Debug.WriteLine("Unknown record type");
            }
        }

        private void SaveChanges()
        {
            Database.Instance.EditRecord(_record.ID, "date", entryDate.Value);
            _record.Date = entryDate.Value;

            if (_record is TimeWorkSession timeRecord)
            {
                Database.Instance.EditRecord(_record.ID, "price_per_hour", entryHourRate.Value);
                Database.Instance.EditRecord(_record.ID, "hours", entryHours.Value);
                Database.Instance.EditRecord(_record.ID, "minutes", entryMinutes.Value);

                timeRecord.HourRate = (float)entryHourRate.Value;
                timeRecord.Hours = (int)entryHours.Value;
                timeRecord.Minutes = (int)entryMinutes.Value;
            }
            else if (_record is FixedPriceWork fixedRecord)
            {
                Database.Instance.EditRecord(_record.ID, "amount", entryFixed.Value);
                fixedRecord.Price = (float)entryFixed.Value;
            }
            else
            {
                Debug.WriteLine("Unknown record type");
            }

            RecordEdited?.Invoke(this, EventArgs.Empty);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
