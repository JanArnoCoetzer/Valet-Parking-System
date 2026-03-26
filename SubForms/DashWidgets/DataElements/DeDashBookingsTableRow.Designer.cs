namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    partial class DeDashBookingsTableRow
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
            BackPanel = new TableLayoutPanel();
            txtTime = new Label();
            txtParkingSpace = new Label();
            txtCarReg = new Label();
            txtName = new Label();
            txtBookingId = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(BackPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 1F));
            tableLayoutPanel1.Size = new Size(1440, 40);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 5;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.Controls.Add(txtTime, 4, 0);
            BackPanel.Controls.Add(txtParkingSpace, 3, 0);
            BackPanel.Controls.Add(txtCarReg, 2, 0);
            BackPanel.Controls.Add(txtName, 1, 0);
            BackPanel.Controls.Add(txtBookingId, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 1;
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(1440, 39);
            BackPanel.TabIndex = 3;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.BackColor = Color.Transparent;
            txtTime.Dock = DockStyle.Fill;
            txtTime.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtTime.ForeColor = Color.FromArgb(37, 42, 53);
            txtTime.Location = new Point(1152, 0);
            txtTime.Margin = new Padding(0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(288, 39);
            txtTime.TabIndex = 20;
            txtTime.Text = "Time";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtParkingSpace
            // 
            txtParkingSpace.AutoSize = true;
            txtParkingSpace.BackColor = Color.Transparent;
            txtParkingSpace.Dock = DockStyle.Fill;
            txtParkingSpace.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtParkingSpace.ForeColor = Color.FromArgb(37, 42, 53);
            txtParkingSpace.Location = new Point(864, 0);
            txtParkingSpace.Margin = new Padding(0);
            txtParkingSpace.Name = "txtParkingSpace";
            txtParkingSpace.Size = new Size(288, 39);
            txtParkingSpace.TabIndex = 19;
            txtParkingSpace.Text = "ParkingSpace";
            txtParkingSpace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCarReg
            // 
            txtCarReg.AutoSize = true;
            txtCarReg.BackColor = Color.Transparent;
            txtCarReg.Dock = DockStyle.Fill;
            txtCarReg.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtCarReg.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarReg.Location = new Point(576, 0);
            txtCarReg.Margin = new Padding(0);
            txtCarReg.Name = "txtCarReg";
            txtCarReg.Size = new Size(288, 39);
            txtCarReg.TabIndex = 18;
            txtCarReg.Text = "Registration";
            txtCarReg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtName.ForeColor = Color.FromArgb(37, 42, 53);
            txtName.Location = new Point(288, 0);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 39);
            txtName.TabIndex = 17;
            txtName.Text = "Name";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBookingId
            // 
            txtBookingId.AutoSize = true;
            txtBookingId.BackColor = Color.Transparent;
            txtBookingId.Dock = DockStyle.Fill;
            txtBookingId.Font = new Font("Dubai", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookingId.ForeColor = Color.FromArgb(37, 42, 53);
            txtBookingId.Location = new Point(0, 0);
            txtBookingId.Margin = new Padding(0);
            txtBookingId.Name = "txtBookingId";
            txtBookingId.Size = new Size(288, 39);
            txtBookingId.TabIndex = 11;
            txtBookingId.Text = "ID";
            txtBookingId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 42, 53);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1440, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DeDashBookingsTableRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            MaximumSize = new Size(1440, 40);
            MinimumSize = new Size(1440, 40);
            Name = "DeDashBookingsTableRow";
            Size = new Size(1440, 40);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            BackPanel.ResumeLayout(false);
            BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel BackPanel;
        private Label txtTime;
        private Label txtParkingSpace;
        private Label txtCarReg;
        private Label txtName;
        private Label txtBookingId;
        private PictureBox pictureBox1;
    }
}
