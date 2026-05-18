namespace ind_project_project.UI
{
    partial class DashboardHistoryRecord
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
            lblAmount = new Label();
            lblText = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Dock = DockStyle.Top;
            lblAmount.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(0, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 40);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "label1";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Dock = DockStyle.Fill;
            lblText.Location = new Point(0, 40);
            lblText.Name = "lblText";
            lblText.Size = new Size(38, 15);
            lblText.TabIndex = 1;
            lblText.Text = "label1";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(263, 0);
            button1.Name = "button1";
            button1.Size = new Size(78, 23);
            button1.TabIndex = 2;
            button1.Text = "COPY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DashboardHistoryRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(button1);
            Controls.Add(lblText);
            Controls.Add(lblAmount);
            Name = "DashboardHistoryRecord";
            Size = new Size(341, 167);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        internal Label lblAmount;
        internal Label lblText;
    }
}
