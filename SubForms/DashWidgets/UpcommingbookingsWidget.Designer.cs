namespace Valet_Parking_System.SubForms.Widgets
{
    partial class UpcommingbookingsWidget
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
            tableLayoutPanel1 = new TableLayoutPanel();
            UpcomingBookingsTableContentPanel = new FlowLayoutPanel();
            HeadingLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(254, 254, 254);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(UpcomingBookingsTableContentPanel, 1, 2);
            tableLayoutPanel1.Controls.Add(HeadingLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1520, 488);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UpcomingBookingsTableContentPanel
            // 
            UpcomingBookingsTableContentPanel.BackColor = Color.FromArgb(228, 232, 233);
            UpcomingBookingsTableContentPanel.BorderStyle = BorderStyle.Fixed3D;
            UpcomingBookingsTableContentPanel.Dock = DockStyle.Fill;
            UpcomingBookingsTableContentPanel.Location = new Point(40, 140);
            UpcomingBookingsTableContentPanel.Margin = new Padding(0);
            UpcomingBookingsTableContentPanel.Name = "UpcomingBookingsTableContentPanel";
            UpcomingBookingsTableContentPanel.Size = new Size(1440, 328);
            UpcomingBookingsTableContentPanel.TabIndex = 4;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.BackColor = Color.FromArgb(254, 254, 254);
            HeadingLabel.Dock = DockStyle.Fill;
            HeadingLabel.Font = new Font("Dubai Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadingLabel.ForeColor = Color.FromArgb(37, 42, 53);
            HeadingLabel.Location = new Point(40, 0);
            HeadingLabel.Margin = new Padding(0);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(1440, 80);
            HeadingLabel.TabIndex = 1;
            HeadingLabel.Text = "Upcoming Booking's";
            HeadingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(254, 254, 254);
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label5, 4, 0);
            tableLayoutPanel2.Controls.Add(label4, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(40, 80);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1440, 60);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(254, 254, 254);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Dubai", 14F);
            label5.ForeColor = Color.FromArgb(37, 42, 53);
            label5.Location = new Point(1152, 0);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(288, 60);
            label5.TabIndex = 5;
            label5.Text = "Time";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(254, 254, 254);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Dubai", 14F);
            label4.ForeColor = Color.FromArgb(37, 42, 53);
            label4.Location = new Point(864, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(288, 60);
            label4.TabIndex = 4;
            label4.Text = "Parking Space";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(254, 254, 254);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Dubai", 14F);
            label3.ForeColor = Color.FromArgb(37, 42, 53);
            label3.Location = new Point(576, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(288, 60);
            label3.TabIndex = 3;
            label3.Text = "Registration";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(254, 254, 254);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Dubai", 14F);
            label2.ForeColor = Color.FromArgb(37, 42, 53);
            label2.Location = new Point(288, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(288, 60);
            label2.TabIndex = 2;
            label2.Text = "Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(254, 254, 254);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Dubai", 14F);
            label1.ForeColor = Color.FromArgb(37, 42, 53);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(288, 60);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpcommingbookingsWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "UpcommingbookingsWidget";
            Size = new Size(1520, 488);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeadingLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private FlowLayoutPanel UpcomingBookingsTableContentPanel;
    }
}
