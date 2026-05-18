namespace ind_project_project.UI
{
    partial class FormConfirmWipe
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
            panel1 = new Panel();
            panel2 = new Panel();
            centerPanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            centerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 156);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(centerPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 96);
            panel2.TabIndex = 2;
            // 
            // centerPanel
            // 
            centerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            centerPanel.AutoSize = true;
            centerPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            centerPanel.Controls.Add(button2);
            centerPanel.Controls.Add(button1);
            centerPanel.Location = new Point(125, 23);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(231, 48);
            centerPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(123, 0);
            button2.Name = "button2";
            button2.Size = new Size(105, 45);
            button2.TabIndex = 1;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(117, 45);
            button1.TabIndex = 0;
            button1.Text = "ACCEPT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 40);
            label2.Margin = new Padding(3, 5, 3, 20);
            label2.MinimumSize = new Size(0, 20);
            label2.Name = "label2";
            label2.Size = new Size(487, 20);
            label2.TabIndex = 1;
            label2.Text = "If you accept you will erase all data. This action is irreversible.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 0, 3, 10);
            label1.MinimumSize = new Size(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(487, 40);
            label1.TabIndex = 0;
            label1.Text = "DATA WIPE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConfirmWipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 156);
            Controls.Add(panel1);
            Name = "FormConfirmWipe";
            Text = "Confirmation";
            Load += FormConfirmWipe_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            centerPanel.ResumeLayout(false);
            centerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Panel centerPanel;
        private Button button2;
        internal Panel panel2;
    }
}