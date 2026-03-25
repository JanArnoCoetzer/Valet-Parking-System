namespace Valet_Parking_System.SubForms
{
    partial class DashBoardSubForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            upcommingbookingsWidget1 = new Valet_Parking_System.SubForms.Widgets.UpcommingbookingsWidget();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundedWidget1 = new Valet_Parking_System.SubForms.Widgets.RoundedWidget();
            roundedWidget2 = new Valet_Parking_System.SubForms.Widgets.RoundedWidget();
            roundedWidget3 = new Valet_Parking_System.SubForms.Widgets.RoundedWidget();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(228, 232, 233);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1560, 757);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(upcommingbookingsWidget1, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(1520, 717);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // upcommingbookingsWidget1
            // 
            upcommingbookingsWidget1.BackColor = Color.FromArgb(254, 254, 254);
            upcommingbookingsWidget1.CornerRadius = 12;
            upcommingbookingsWidget1.Dock = DockStyle.Fill;
            upcommingbookingsWidget1.Location = new Point(0, 229);
            upcommingbookingsWidget1.Margin = new Padding(0);
            upcommingbookingsWidget1.Name = "upcommingbookingsWidget1";
            upcommingbookingsWidget1.Size = new Size(1520, 488);
            upcommingbookingsWidget1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(roundedWidget1, 0, 0);
            tableLayoutPanel3.Controls.Add(roundedWidget2, 2, 0);
            tableLayoutPanel3.Controls.Add(roundedWidget3, 4, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1520, 209);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // roundedWidget1
            // 
            roundedWidget1.AutoSize = true;
            roundedWidget1.BackColor = Color.FromArgb(254, 254, 254);
            roundedWidget1.CornerRadius = 12;
            roundedWidget1.Dock = DockStyle.Fill;
            roundedWidget1.Location = new Point(3, 3);
            roundedWidget1.Name = "roundedWidget1";
            roundedWidget1.SetHeading = "Today's Bookings";
            roundedWidget1.SetValue = "28";
            roundedWidget1.Size = new Size(487, 203);
            roundedWidget1.TabIndex = 0;
            // 
            // roundedWidget2
            // 
            roundedWidget2.AutoSize = true;
            roundedWidget2.BackColor = Color.FromArgb(254, 254, 254);
            roundedWidget2.CornerRadius = 12;
            roundedWidget2.Dock = DockStyle.Fill;
            roundedWidget2.Location = new Point(516, 3);
            roundedWidget2.Name = "roundedWidget2";
            roundedWidget2.SetHeading = "Available Parking";
            roundedWidget2.SetValue = "43";
            roundedWidget2.Size = new Size(487, 203);
            roundedWidget2.TabIndex = 1;
            // 
            // roundedWidget3
            // 
            roundedWidget3.AutoSize = true;
            roundedWidget3.BackColor = Color.FromArgb(254, 254, 254);
            roundedWidget3.CornerRadius = 12;
            roundedWidget3.Dock = DockStyle.Fill;
            roundedWidget3.Location = new Point(1029, 3);
            roundedWidget3.Name = "roundedWidget3";
            roundedWidget3.SetHeading = "Cars in Retreval queue";
            roundedWidget3.SetValue = "6";
            roundedWidget3.Size = new Size(488, 203);
            roundedWidget3.TabIndex = 2;
            // 
            // DashBoardSubForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 242, 243);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "DashBoardSubForm";
            Size = new Size(1560, 757);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Widgets.RoundedWidget roundedWidget1;
        private Widgets.RoundedWidget roundedWidget2;
        private Widgets.RoundedWidget roundedWidget3;
        private Widgets.UpcommingbookingsWidget upcommingbookingsWidget1;
    }
}