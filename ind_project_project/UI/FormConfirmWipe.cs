using ind_project_project.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ind_project_project.UI
{
    public partial class FormConfirmWipe : Form
    {
        public FormConfirmWipe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.Instance.WipeRecords();
            FormConfirmWipe.ActiveForm?.Close();
        }

        private void FormConfirmWipe_Load(object sender, EventArgs e)
        {
            //int X = panel2.Size.Width / 2 - centerPanel.Size.Width / 2;
            //centerPanel.Location = new Point(X, centerPanel.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConfirmWipe.ActiveForm?.Close();
        }
    }
}
