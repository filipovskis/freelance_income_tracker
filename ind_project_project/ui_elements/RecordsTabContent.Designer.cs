namespace ind_project_project.ui_elements
{
    partial class RecordsTabContent
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGrid = new DataGridView();
            panel1 = new Panel();
            btnWipe = new Button();
            btnEdit = new Button();
            btnSelectAll = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            lblNetto = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            lblTotalTax = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            lblTotalIncome = new Label();
            date = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            estimatedTax = new DataGridViewTextBoxColumn();
            Income = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { date, Amount, estimatedTax, Income });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.ShowEditingIcon = false;
            dataGrid.Size = new Size(1190, 730);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGridView1_CellContentClick;
            dataGrid.CellContentDoubleClick += dataGrid_CellContentDoubleClick;
            dataGrid.ColumnRemoved += dataGrid_ColumnRemoved;
            dataGrid.SelectionChanged += dataGrid_SelectionChanged;
            dataGrid.UserDeletedRow += dataGrid_UserDeletedRow;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnWipe);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSelectAll);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 660);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1190, 70);
            panel1.TabIndex = 1;
            // 
            // btnWipe
            // 
            btnWipe.BackgroundImageLayout = ImageLayout.None;
            btnWipe.Dock = DockStyle.Right;
            btnWipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWipe.ForeColor = Color.DarkRed;
            btnWipe.Location = new Point(814, 10);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(123, 50);
            btnWipe.TabIndex = 5;
            btnWipe.Text = "WIPE ALL DATA";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackgroundImageLayout = ImageLayout.None;
            btnEdit.Dock = DockStyle.Right;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.SeaGreen;
            btnEdit.Location = new Point(937, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(90, 50);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Dock = DockStyle.Right;
            btnSelectAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectAll.Location = new Point(1027, 10);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(153, 50);
            btnSelectAll.TabIndex = 4;
            btnSelectAll.Text = "SELECT ALL";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += btnSelectAll_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Controls.Add(lblNetto);
            flowLayoutPanel3.Dock = DockStyle.Left;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(287, 10);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(196, 50);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 0;
            label3.Text = "Netto sum";
            // 
            // lblNetto
            // 
            lblNetto.AutoSize = true;
            lblNetto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetto.ForeColor = Color.Green;
            lblNetto.Location = new Point(3, 21);
            lblNetto.Name = "lblNetto";
            lblNetto.Size = new Size(16, 21);
            lblNetto.TabIndex = 1;
            lblNetto.Text = "-";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(lblTotalTax);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(154, 10);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(133, 50);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 0;
            label2.Text = "Total tax";
            // 
            // lblTotalTax
            // 
            lblTotalTax.AutoSize = true;
            lblTotalTax.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTax.ForeColor = Color.Maroon;
            lblTotalTax.Location = new Point(3, 21);
            lblTotalTax.Name = "lblTotalTax";
            lblTotalTax.Size = new Size(16, 21);
            lblTotalTax.TabIndex = 1;
            lblTotalTax.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblTotalIncome);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(144, 50);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "Total income";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalIncome.Location = new Point(3, 21);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(16, 21);
            lblTotalIncome.TabIndex = 1;
            lblTotalIncome.Text = "-";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount (EUR)";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // estimatedTax
            // 
            estimatedTax.HeaderText = "Estimated Tax (EUR)";
            estimatedTax.Name = "estimatedTax";
            estimatedTax.ReadOnly = true;
            estimatedTax.ToolTipText = "Uses ~40%";
            // 
            // Income
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Income.DefaultCellStyle = dataGridViewCellStyle1;
            Income.HeaderText = "Netto (EUR)";
            Income.Name = "Income";
            Income.ReadOnly = true;
            // 
            // RecordsTabContent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(dataGrid);
            Name = "RecordsTabContent";
            Size = new Size(1190, 730);
            Load += OnLoaded;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label lblTotalIncome;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private Label lblNetto;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private Label lblTotalTax;
        private Button btnSelectAll;
        private Button btnWipe;
        private Button btnEdit;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn estimatedTax;
        private DataGridViewTextBoxColumn Income;
    }
}
