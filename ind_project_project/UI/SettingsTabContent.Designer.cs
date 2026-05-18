namespace ind_project_project.UI
{
    partial class SettingsTabContent
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
            panel1 = new Panel();
            label2 = new Label();
            entryMinWage = new NumericUpDown();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            estimatedTaxRate = new NumericUpDown();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            hourlyRate = new NumericUpDown();
            label6 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            label7 = new Label();
            entryNonTaxable = new NumericUpDown();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryMinWage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)estimatedTaxRate).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hourlyRate).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entryNonTaxable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(entryMinWage);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 5, 0, 5);
            panel1.Size = new Size(764, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(0, 26);
            label2.Name = "label2";
            label2.Size = new Size(234, 19);
            label2.TabIndex = 2;
            label2.Text = "Threshold base for VSAOI calculation";
            // 
            // entryMinWage
            // 
            entryMinWage.AutoSize = true;
            entryMinWage.Location = new Point(639, 13);
            entryMinWage.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            entryMinWage.Name = "entryMinWage";
            entryMinWage.Size = new Size(120, 23);
            entryMinWage.TabIndex = 1;
            entryMinWage.ValueChanged += entryMinWage_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(199, 21);
            label1.TabIndex = 0;
            label1.Text = "Minimum monthly wage";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(estimatedTaxRate);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 119);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 5, 0, 5);
            panel2.Size = new Size(762, 52);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(0, 26);
            label3.Name = "label3";
            label3.Size = new Size(422, 19);
            label3.TabIndex = 2;
            label3.Text = "Default percentage used for quick, rough tax calculations per record";
            // 
            // estimatedTaxRate
            // 
            estimatedTaxRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            estimatedTaxRate.Location = new Point(637, 19);
            estimatedTaxRate.Name = "estimatedTaxRate";
            estimatedTaxRate.Size = new Size(120, 23);
            estimatedTaxRate.TabIndex = 1;
            estimatedTaxRate.ValueChanged += estimatedTaxRate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 5);
            label4.Name = "label4";
            label4.Size = new Size(206, 21);
            label4.TabIndex = 0;
            label4.Text = "Estimated tax rate (0-100)";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = SystemColors.ControlLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(hourlyRate);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(3, 177);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 5, 0, 5);
            panel3.Size = new Size(762, 52);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(0, 26);
            label5.Name = "label5";
            label5.Size = new Size(401, 19);
            label5.TabIndex = 2;
            label5.Text = "Base hourly pay rate applied automatically to new work sessions";
            // 
            // hourlyRate
            // 
            hourlyRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            hourlyRate.Location = new Point(637, 18);
            hourlyRate.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            hourlyRate.Name = "hourlyRate";
            hourlyRate.Size = new Size(120, 23);
            hourlyRate.TabIndex = 1;
            hourlyRate.ValueChanged += hourlyRate_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 5);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 0;
            label6.Text = "Hourly Rate";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(926, 496);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = SystemColors.ControlLight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(entryNonTaxable);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(3, 61);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 5, 0, 5);
            panel4.Size = new Size(764, 52);
            panel4.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(0, 26);
            label7.Name = "label7";
            label7.Size = new Size(379, 19);
            label7.TabIndex = 2;
            label7.Text = "Monthly tax-exempt income threshold for the self-employed";
            // 
            // entryNonTaxable
            // 
            entryNonTaxable.AutoSize = true;
            entryNonTaxable.Location = new Point(639, 18);
            entryNonTaxable.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            entryNonTaxable.Name = "entryNonTaxable";
            entryNonTaxable.Size = new Size(120, 23);
            entryNonTaxable.TabIndex = 1;
            entryNonTaxable.ValueChanged += entryNonTaxable_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 5);
            label8.Name = "label8";
            label8.Size = new Size(183, 21);
            label8.TabIndex = 0;
            label8.Text = "Non taxable minimum";
            // 
            // SettingsTabContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "SettingsTabContent";
            Padding = new Padding(10);
            Size = new Size(946, 516);
            Load += SettingsTabContent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryMinWage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)estimatedTaxRate).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hourlyRate).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entryNonTaxable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private NumericUpDown entryMinWage;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private NumericUpDown estimatedTaxRate;
        private Label label4;
        private Label label2;
        private Panel panel3;
        private Label label5;
        private NumericUpDown hourlyRate;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Label label7;
        private NumericUpDown entryNonTaxable;
        private Label label8;
    }
}
