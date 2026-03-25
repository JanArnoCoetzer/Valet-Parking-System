namespace Valet_Parking_System.SubForms.BookingWidgets.DataElements
{
    partial class DeBookingTableRow
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
            TxtTo = new Label();
            txtFrom = new Label();
            txtName = new Label();
            txtCarReg = new Label();
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
            tableLayoutPanel1.Size = new Size(930, 40);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 6;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09091F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182F));
            BackPanel.Controls.Add(txtTime, 5, 0);
            BackPanel.Controls.Add(TxtTo, 4, 0);
            BackPanel.Controls.Add(txtFrom, 3, 0);
            BackPanel.Controls.Add(txtName, 2, 0);
            BackPanel.Controls.Add(txtCarReg, 1, 0);
            BackPanel.Controls.Add(txtBookingId, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 1;
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(930, 39);
            BackPanel.TabIndex = 3;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.BackColor = Color.Transparent;
            txtTime.Dock = DockStyle.Fill;
            txtTime.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtTime.ForeColor = Color.FromArgb(37, 42, 53);
            txtTime.Location = new Point(760, 0);
            txtTime.Margin = new Padding(0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(170, 39);
            txtTime.TabIndex = 21;
            txtTime.Text = "Time";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            txtTime.MouseClick += TableElement_Clicked;
            txtTime.MouseEnter += TableElement_MouseHover;
            txtTime.MouseLeave += TableElement_MouseLeave;
            // 
            // TxtTo
            // 
            TxtTo.AutoSize = true;
            TxtTo.BackColor = Color.Transparent;
            TxtTo.Dock = DockStyle.Fill;
            TxtTo.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            TxtTo.ForeColor = Color.FromArgb(37, 42, 53);
            TxtTo.Location = new Point(591, 0);
            TxtTo.Margin = new Padding(0);
            TxtTo.Name = "TxtTo";
            TxtTo.Size = new Size(169, 39);
            TxtTo.TabIndex = 20;
            TxtTo.Text = "To";
            TxtTo.TextAlign = ContentAlignment.MiddleCenter;
            TxtTo.MouseClick += TableElement_Clicked;
            TxtTo.MouseEnter += TableElement_MouseHover;
            TxtTo.MouseLeave += TableElement_MouseLeave;
            // 
            // txtFrom
            // 
            txtFrom.AutoSize = true;
            txtFrom.BackColor = Color.Transparent;
            txtFrom.Dock = DockStyle.Fill;
            txtFrom.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtFrom.ForeColor = Color.FromArgb(37, 42, 53);
            txtFrom.Location = new Point(422, 0);
            txtFrom.Margin = new Padding(0);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(169, 39);
            txtFrom.TabIndex = 19;
            txtFrom.Text = "From";
            txtFrom.TextAlign = ContentAlignment.MiddleCenter;
            txtFrom.MouseClick += TableElement_Clicked;
            txtFrom.MouseEnter += TableElement_MouseHover;
            txtFrom.MouseLeave += TableElement_MouseLeave;
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.BackColor = Color.Transparent;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtName.ForeColor = Color.FromArgb(37, 42, 53);
            txtName.Location = new Point(253, 0);
            txtName.Margin = new Padding(0);
            txtName.Name = "txtName";
            txtName.Size = new Size(169, 39);
            txtName.TabIndex = 18;
            txtName.Text = "Name";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            txtName.MouseClick += TableElement_Clicked;
            txtName.MouseEnter += TableElement_MouseHover;
            txtName.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarReg
            // 
            txtCarReg.AutoSize = true;
            txtCarReg.BackColor = Color.Transparent;
            txtCarReg.Dock = DockStyle.Fill;
            txtCarReg.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtCarReg.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarReg.Location = new Point(84, 0);
            txtCarReg.Margin = new Padding(0);
            txtCarReg.Name = "txtCarReg";
            txtCarReg.Size = new Size(169, 39);
            txtCarReg.TabIndex = 17;
            txtCarReg.Text = "Reg#####";
            txtCarReg.TextAlign = ContentAlignment.MiddleCenter;
            txtCarReg.MouseClick += TableElement_Clicked;
            txtCarReg.MouseEnter += TableElement_MouseHover;
            txtCarReg.MouseLeave += TableElement_MouseLeave;
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
            txtBookingId.Size = new Size(84, 39);
            txtBookingId.TabIndex = 11;
            txtBookingId.Text = "ID";
            txtBookingId.TextAlign = ContentAlignment.MiddleCenter;
            txtBookingId.MouseClick += TableElement_Clicked;
            txtBookingId.MouseEnter += TableElement_MouseHover;
            txtBookingId.MouseLeave += TableElement_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 42, 53);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DeBookingTableRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 232, 233);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            MaximumSize = new Size(930, 40);
            MinimumSize = new Size(930, 20);
            Name = "DeBookingTableRow";
            Size = new Size(930, 40);
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
        private Label TxtTo;
        private Label txtFrom;
        private Label txtName;
        private Label txtCarReg;
        private Label txtBookingId;
        private PictureBox pictureBox1;
    }
}
