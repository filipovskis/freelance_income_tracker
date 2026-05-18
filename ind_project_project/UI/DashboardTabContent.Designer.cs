namespace ind_project_project.UI
{
    partial class DashboardTabContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            hourAmtEntry = new NumericUpDown();
            minAmtEntry = new NumericUpDown();
            timeInvoiceCreate = new Button();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblHoursHelp = new Label();
            label5 = new Label();
            flowHistory = new FlowLayoutPanel();
            lblHistoryTitle = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            label8 = new Label();
            lblFixedHelp = new Label();
            fixedAmtEntry = new NumericUpDown();
            fixedInvoiceCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)hourAmtEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAmtEntry).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowHistory.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fixedAmtEntry).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(10, 45);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 0;
            label1.Text = "HOURS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(10, 133);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "MINUTES";
            // 
            // hourAmtEntry
            // 
            hourAmtEntry.AutoSize = true;
            hourAmtEntry.Location = new Point(13, 100);
            hourAmtEntry.Margin = new Padding(3, 3, 3, 10);
            hourAmtEntry.MinimumSize = new Size(75, 0);
            hourAmtEntry.Name = "hourAmtEntry";
            hourAmtEntry.Size = new Size(75, 23);
            hourAmtEntry.TabIndex = 2;
            // 
            // minAmtEntry
            // 
            minAmtEntry.AutoSize = true;
            minAmtEntry.Location = new Point(13, 188);
            minAmtEntry.Margin = new Padding(3, 3, 3, 15);
            minAmtEntry.MinimumSize = new Size(75, 0);
            minAmtEntry.Name = "minAmtEntry";
            minAmtEntry.Size = new Size(75, 23);
            minAmtEntry.TabIndex = 4;
            // 
            // timeInvoiceCreate
            // 
            timeInvoiceCreate.AutoSize = true;
            timeInvoiceCreate.Dock = DockStyle.Bottom;
            timeInvoiceCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeInvoiceCreate.Location = new Point(13, 229);
            timeInvoiceCreate.Name = "timeInvoiceCreate";
            timeInvoiceCreate.Size = new Size(294, 40);
            timeInvoiceCreate.TabIndex = 5;
            timeInvoiceCreate.Text = "Create";
            timeInvoiceCreate.UseVisualStyleBackColor = true;
            timeInvoiceCreate.Click += timeInvoiceCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(10, 10);
            label4.Margin = new Padding(0, 0, 0, 10);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 7;
            label4.Text = "Time based session";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblHoursHelp);
            flowLayoutPanel1.Controls.Add(hourAmtEntry);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(minAmtEntry);
            flowLayoutPanel1.Controls.Add(timeInvoiceCreate);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 20, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(562, 320);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lblHoursHelp
            // 
            lblHoursHelp.AutoSize = true;
            lblHoursHelp.Font = new Font("Segoe UI", 9.75F);
            lblHoursHelp.Location = new Point(13, 77);
            lblHoursHelp.Margin = new Padding(3, 0, 3, 3);
            lblHoursHelp.Name = "lblHoursHelp";
            lblHoursHelp.Size = new Size(278, 17);
            lblHoursHelp.TabIndex = 9;
            lblHoursHelp.Text = "Please input how many hours have been spent";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(13, 165);
            label5.Margin = new Padding(3, 0, 3, 3);
            label5.Name = "label5";
            label5.Size = new Size(290, 17);
            label5.TabIndex = 8;
            label5.Text = "Please input how many minutes have been spent";
            // 
            // flowHistory
            // 
            flowHistory.AutoScroll = true;
            flowHistory.BorderStyle = BorderStyle.FixedSingle;
            flowHistory.Controls.Add(lblHistoryTitle);
            flowHistory.Dock = DockStyle.Right;
            flowHistory.FlowDirection = FlowDirection.TopDown;
            flowHistory.Location = new Point(562, 0);
            flowHistory.MaximumSize = new Size(600, 0);
            flowHistory.Name = "flowHistory";
            flowHistory.Padding = new Padding(10);
            flowHistory.Size = new Size(450, 702);
            flowHistory.TabIndex = 9;
            flowHistory.WrapContents = false;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Dock = DockStyle.Top;
            lblHistoryTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHistoryTitle.ForeColor = SystemColors.GrayText;
            lblHistoryTitle.Location = new Point(10, 10);
            lblHistoryTitle.Margin = new Padding(0, 0, 0, 10);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(70, 25);
            lblHistoryTitle.TabIndex = 10;
            lblHistoryTitle.Text = "History";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(label8);
            flowLayoutPanel3.Controls.Add(lblFixedHelp);
            flowLayoutPanel3.Controls.Add(fixedAmtEntry);
            flowLayoutPanel3.Controls.Add(fixedInvoiceCreate);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 320);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(562, 382);
            flowLayoutPanel3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(10, 10);
            label3.Margin = new Padding(0, 0, 0, 10);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 10;
            label3.Text = "Fixed amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.Location = new Point(10, 45);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(67, 32);
            label8.TabIndex = 11;
            label8.Text = "SUM";
            // 
            // lblFixedHelp
            // 
            lblFixedHelp.AutoSize = true;
            lblFixedHelp.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFixedHelp.Location = new Point(13, 77);
            lblFixedHelp.Margin = new Padding(3, 0, 3, 3);
            lblFixedHelp.Name = "lblFixedHelp";
            lblFixedHelp.Size = new Size(156, 17);
            lblFixedHelp.TabIndex = 14;
            lblFixedHelp.Text = "Please input the final sum";
            // 
            // fixedAmtEntry
            // 
            fixedAmtEntry.AutoSize = true;
            fixedAmtEntry.Location = new Point(13, 100);
            fixedAmtEntry.Margin = new Padding(3, 3, 3, 15);
            fixedAmtEntry.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            fixedAmtEntry.MinimumSize = new Size(75, 0);
            fixedAmtEntry.Name = "fixedAmtEntry";
            fixedAmtEntry.Size = new Size(75, 23);
            fixedAmtEntry.TabIndex = 12;
            // 
            // fixedInvoiceCreate
            // 
            fixedInvoiceCreate.AutoSize = true;
            fixedInvoiceCreate.Dock = DockStyle.Bottom;
            fixedInvoiceCreate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fixedInvoiceCreate.Location = new Point(13, 141);
            fixedInvoiceCreate.Name = "fixedInvoiceCreate";
            fixedInvoiceCreate.Size = new Size(294, 40);
            fixedInvoiceCreate.TabIndex = 13;
            fixedInvoiceCreate.Text = "Create";
            fixedInvoiceCreate.UseVisualStyleBackColor = true;
            fixedInvoiceCreate.Click += fixedInvoiceCreate_Click;
            // 
            // DashboardTabContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowHistory);
            Name = "DashboardTabContent";
            Size = new Size(1012, 702);
            ((System.ComponentModel.ISupportInitialize)hourAmtEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAmtEntry).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowHistory.ResumeLayout(false);
            flowHistory.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fixedAmtEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown hourAmtEntry;
        private NumericUpDown minAmtEntry;
        private Button timeInvoiceCreate;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblHoursHelp;
        private Label label5;
        private FlowLayoutPanel flowHistory;
        private Label lblHistoryTitle;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private Label label8;
        private Label lblFixedHelp;
        private NumericUpDown fixedAmtEntry;
        private Button fixedInvoiceCreate;
    }
}
