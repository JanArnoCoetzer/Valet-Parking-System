namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    partial class StatusHotbarWidget
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
            txtCarsFoRetrieval = new Label();
            txtParkingAvailable = new Label();
            txtTodaysBookings = new Label();
            label2 = new Label();
            label1 = new Label();
            HeadingLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtCarsFoRetrieval, 5, 2);
            tableLayoutPanel1.Controls.Add(txtParkingAvailable, 3, 2);
            tableLayoutPanel1.Controls.Add(txtTodaysBookings, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 5, 1);
            tableLayoutPanel1.Controls.Add(label1, 3, 1);
            tableLayoutPanel1.Controls.Add(HeadingLabel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.7857151F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.21429F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1520, 209);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtCarsFoRetrieval
            // 
            txtCarsFoRetrieval.AutoSize = true;
            txtCarsFoRetrieval.Dock = DockStyle.Fill;
            txtCarsFoRetrieval.Font = new Font("Dubai", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCarsFoRetrieval.ForeColor = Color.FromArgb(8, 108, 236);
            txtCarsFoRetrieval.Location = new Point(1032, 65);
            txtCarsFoRetrieval.Margin = new Padding(0);
            txtCarsFoRetrieval.Name = "txtCarsFoRetrieval";
            txtCarsFoRetrieval.Size = new Size(466, 123);
            txtCarsFoRetrieval.TabIndex = 6;
            txtCarsFoRetrieval.Text = "0";
            txtCarsFoRetrieval.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtParkingAvailable
            // 
            txtParkingAvailable.AutoSize = true;
            txtParkingAvailable.Dock = DockStyle.Fill;
            txtParkingAvailable.Font = new Font("Dubai", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtParkingAvailable.ForeColor = Color.FromArgb(8, 108, 236);
            txtParkingAvailable.Location = new Point(526, 65);
            txtParkingAvailable.Margin = new Padding(0);
            txtParkingAvailable.Name = "txtParkingAvailable";
            txtParkingAvailable.Size = new Size(466, 123);
            txtParkingAvailable.TabIndex = 5;
            txtParkingAvailable.Text = "0";
            txtParkingAvailable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTodaysBookings
            // 
            txtTodaysBookings.AutoSize = true;
            txtTodaysBookings.Dock = DockStyle.Fill;
            txtTodaysBookings.Font = new Font("Dubai", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTodaysBookings.ForeColor = Color.FromArgb(8, 108, 236);
            txtTodaysBookings.Location = new Point(20, 65);
            txtTodaysBookings.Margin = new Padding(0);
            txtTodaysBookings.Name = "txtTodaysBookings";
            txtTodaysBookings.Size = new Size(466, 123);
            txtTodaysBookings.TabIndex = 4;
            txtTodaysBookings.Text = "0";
            txtTodaysBookings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Dubai Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(37, 42, 53);
            label2.Location = new Point(1032, 20);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(466, 45);
            label2.TabIndex = 3;
            label2.Text = "Cars for Retrieval";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Dubai Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(37, 42, 53);
            label1.Location = new Point(526, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(466, 45);
            label1.TabIndex = 2;
            label1.Text = "Parking Available";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Dock = DockStyle.Fill;
            HeadingLabel.Font = new Font("Dubai Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadingLabel.ForeColor = Color.FromArgb(37, 42, 53);
            HeadingLabel.Location = new Point(20, 20);
            HeadingLabel.Margin = new Padding(0);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(466, 45);
            HeadingLabel.TabIndex = 1;
            HeadingLabel.Text = "Today's Bookings";
            HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusHotbarWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "StatusHotbarWidget";
            Size = new Size(1520, 209);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label HeadingLabel;
        private Label label2;
        private Label txtCarsFoRetrieval;
        private Label txtParkingAvailable;
        private Label txtTodaysBookings;
    }
}
