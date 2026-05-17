namespace ind_project_project.ui_elements
{
    partial class EditRecord
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            divFixedSum = new FlowLayoutPanel();
            label2 = new Label();
            divDate = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            entryDate = new DateTimePicker();
            entryFixed = new NumericUpDown();
            divHours = new FlowLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            entryHours = new NumericUpDown();
            divMinutes = new FlowLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            entryMinutes = new NumericUpDown();
            divHourRate = new FlowLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            entryHourRate = new NumericUpDown();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            divFixedSum.SuspendLayout();
            divDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryFixed).BeginInit();
            divHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryHours).BeginInit();
            divMinutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryMinutes).BeginInit();
            divHourRate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryHourRate).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(divDate);
            flowLayoutPanel1.Controls.Add(divFixedSum);
            flowLayoutPanel1.Controls.Add(divHours);
            flowLayoutPanel1.Controls.Add(divMinutes);
            flowLayoutPanel1.Controls.Add(divHourRate);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(816, 730);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(3, 0, 3, 5);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // divFixedSum
            // 
            divFixedSum.AutoSize = true;
            divFixedSum.Controls.Add(label1);
            divFixedSum.Controls.Add(label2);
            divFixedSum.Controls.Add(entryFixed);
            divFixedSum.FlowDirection = FlowDirection.TopDown;
            divFixedSum.Location = new Point(3, 108);
            divFixedSum.Name = "divFixedSum";
            divFixedSum.Padding = new Padding(10);
            divFixedSum.Size = new Size(233, 99);
            divFixedSum.TabIndex = 1;
            divFixedSum.WrapContents = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 38);
            label2.Margin = new Padding(3, 0, 3, 5);
            label2.Name = "label2";
            label2.Size = new Size(188, 17);
            label2.TabIndex = 2;
            label2.Text = "Please input the sum of invoice";
            // 
            // divDate
            // 
            divDate.AutoSize = true;
            divDate.Controls.Add(label3);
            divDate.Controls.Add(label4);
            divDate.Controls.Add(entryDate);
            divDate.FlowDirection = FlowDirection.TopDown;
            divDate.Location = new Point(3, 3);
            divDate.Name = "divDate";
            divDate.Padding = new Padding(10);
            divDate.Size = new Size(564, 99);
            divDate.TabIndex = 3;
            divDate.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 10);
            label3.Margin = new Padding(3, 0, 3, 5);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 38);
            label4.Margin = new Padding(3, 0, 3, 5);
            label4.Name = "label4";
            label4.Size = new Size(207, 17);
            label4.TabIndex = 2;
            label4.Text = "Please input the date of the action";
            // 
            // entryDate
            // 
            entryDate.Dock = DockStyle.Left;
            entryDate.Location = new Point(13, 63);
            entryDate.MinimumSize = new Size(100, 0);
            entryDate.Name = "entryDate";
            entryDate.Size = new Size(538, 23);
            entryDate.TabIndex = 1;
            // 
            // entryFixed
            // 
            entryFixed.Location = new Point(13, 63);
            entryFixed.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            entryFixed.Name = "entryFixed";
            entryFixed.Size = new Size(207, 23);
            entryFixed.TabIndex = 3;
            entryFixed.ThousandsSeparator = true;
            // 
            // divHours
            // 
            divHours.AutoSize = true;
            divHours.Controls.Add(label5);
            divHours.Controls.Add(label6);
            divHours.Controls.Add(entryHours);
            divHours.FlowDirection = FlowDirection.TopDown;
            divHours.Location = new Point(3, 213);
            divHours.Name = "divHours";
            divHours.Padding = new Padding(10);
            divHours.Size = new Size(311, 99);
            divHours.TabIndex = 4;
            divHours.WrapContents = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 10);
            label5.Margin = new Padding(3, 0, 3, 5);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 0;
            label5.Text = "Hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 38);
            label6.Margin = new Padding(3, 0, 3, 5);
            label6.Name = "label6";
            label6.Size = new Size(285, 17);
            label6.TabIndex = 2;
            label6.Text = "Please input the amount of hours spent of work";
            // 
            // entryHours
            // 
            entryHours.Location = new Point(13, 63);
            entryHours.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            entryHours.Name = "entryHours";
            entryHours.Size = new Size(207, 23);
            entryHours.TabIndex = 3;
            entryHours.ThousandsSeparator = true;
            // 
            // divMinutes
            // 
            divMinutes.AutoSize = true;
            divMinutes.Controls.Add(label7);
            divMinutes.Controls.Add(label8);
            divMinutes.Controls.Add(entryMinutes);
            divMinutes.FlowDirection = FlowDirection.TopDown;
            divMinutes.Location = new Point(3, 318);
            divMinutes.Name = "divMinutes";
            divMinutes.Padding = new Padding(10);
            divMinutes.Size = new Size(326, 99);
            divMinutes.TabIndex = 5;
            divMinutes.WrapContents = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 10);
            label7.Margin = new Padding(3, 0, 3, 5);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 0;
            label7.Text = "Minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 38);
            label8.Margin = new Padding(3, 0, 3, 5);
            label8.Name = "label8";
            label8.Size = new Size(300, 17);
            label8.TabIndex = 2;
            label8.Text = "Please input the amount of minutes spent on work";
            // 
            // entryMinutes
            // 
            entryMinutes.Location = new Point(13, 63);
            entryMinutes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            entryMinutes.Name = "entryMinutes";
            entryMinutes.Size = new Size(207, 23);
            entryMinutes.TabIndex = 3;
            entryMinutes.ThousandsSeparator = true;
            // 
            // divHourRate
            // 
            divHourRate.AutoSize = true;
            divHourRate.Controls.Add(label9);
            divHourRate.Controls.Add(label10);
            divHourRate.Controls.Add(entryHourRate);
            divHourRate.FlowDirection = FlowDirection.TopDown;
            divHourRate.Location = new Point(3, 423);
            divHourRate.Name = "divHourRate";
            divHourRate.Padding = new Padding(10);
            divHourRate.Size = new Size(233, 99);
            divHourRate.TabIndex = 6;
            divHourRate.WrapContents = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 10);
            label9.Margin = new Padding(3, 0, 3, 5);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 0;
            label9.Text = "Hour Rate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 38);
            label10.Margin = new Padding(3, 0, 3, 5);
            label10.Name = "label10";
            label10.Size = new Size(44, 17);
            label10.TabIndex = 2;
            label10.Text = "EUR/h";
            // 
            // entryHourRate
            // 
            entryHourRate.Location = new Point(13, 63);
            entryHourRate.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            entryHourRate.Name = "entryHourRate";
            entryHourRate.Size = new Size(207, 23);
            entryHourRate.TabIndex = 3;
            entryHourRate.ThousandsSeparator = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 528);
            button1.Name = "button1";
            button1.Size = new Size(564, 50);
            button1.TabIndex = 7;
            button1.Text = "Save changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 730);
            Controls.Add(flowLayoutPanel1);
            Name = "EditRecord";
            Text = "EditRecord";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            divFixedSum.ResumeLayout(false);
            divFixedSum.PerformLayout();
            divDate.ResumeLayout(false);
            divDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryFixed).EndInit();
            divHours.ResumeLayout(false);
            divHours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryHours).EndInit();
            divMinutes.ResumeLayout(false);
            divMinutes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryMinutes).EndInit();
            divHourRate.ResumeLayout(false);
            divHourRate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryHourRate).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private FlowLayoutPanel divFixedSum;
        private Label label2;
        private FlowLayoutPanel divDate;
        private Label label3;
        private Label label4;
        private DateTimePicker entryDate;
        private NumericUpDown entryFixed;
        private FlowLayoutPanel divHours;
        private Label label5;
        private Label label6;
        private NumericUpDown entryHours;
        private FlowLayoutPanel divMinutes;
        private Label label7;
        private Label label8;
        private NumericUpDown entryMinutes;
        private FlowLayoutPanel divHourRate;
        private Label label9;
        private Label label10;
        private NumericUpDown entryHourRate;
        private Button button1;
    }
}