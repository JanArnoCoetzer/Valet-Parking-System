namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    partial class DeParkingSpacesRow
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
            txtStatus = new Label();
            txtLotIdentifier = new Label();
            txtSpaceID = new Label();
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
            tableLayoutPanel1.Size = new Size(420, 40);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 3;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BackPanel.Controls.Add(txtStatus, 2, 0);
            BackPanel.Controls.Add(txtLotIdentifier, 1, 0);
            BackPanel.Controls.Add(txtSpaceID, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 1;
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(420, 39);
            BackPanel.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.BackColor = Color.Transparent;
            txtStatus.Dock = DockStyle.Fill;
            txtStatus.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtStatus.ForeColor = Color.FromArgb(37, 42, 53);
            txtStatus.Location = new Point(252, 0);
            txtStatus.Margin = new Padding(0);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(168, 39);
            txtStatus.TabIndex = 18;
            txtStatus.Text = "status";
            txtStatus.TextAlign = ContentAlignment.MiddleCenter;
            txtStatus.MouseClick += TableElement_Clicked;
            txtStatus.MouseEnter += TableElement_MouseHover;
            txtStatus.MouseLeave += TableElement_MouseLeave;
            // 
            // txtLotIdentifier
            // 
            txtLotIdentifier.AutoSize = true;
            txtLotIdentifier.BackColor = Color.Transparent;
            txtLotIdentifier.Dock = DockStyle.Fill;
            txtLotIdentifier.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtLotIdentifier.ForeColor = Color.FromArgb(37, 42, 53);
            txtLotIdentifier.Location = new Point(84, 0);
            txtLotIdentifier.Margin = new Padding(0);
            txtLotIdentifier.Name = "txtLotIdentifier";
            txtLotIdentifier.Size = new Size(168, 39);
            txtLotIdentifier.TabIndex = 17;
            txtLotIdentifier.Text = "LotIdentifier";
            txtLotIdentifier.TextAlign = ContentAlignment.MiddleCenter;
            txtLotIdentifier.MouseClick += TableElement_Clicked;
            txtLotIdentifier.MouseEnter += TableElement_MouseHover;
            txtLotIdentifier.MouseLeave += TableElement_MouseLeave;
            // 
            // txtSpaceID
            // 
            txtSpaceID.AutoSize = true;
            txtSpaceID.BackColor = Color.Transparent;
            txtSpaceID.Dock = DockStyle.Fill;
            txtSpaceID.Font = new Font("Dubai", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSpaceID.ForeColor = Color.FromArgb(37, 42, 53);
            txtSpaceID.Location = new Point(0, 0);
            txtSpaceID.Margin = new Padding(0);
            txtSpaceID.Name = "txtSpaceID";
            txtSpaceID.Size = new Size(84, 39);
            txtSpaceID.TabIndex = 11;
            txtSpaceID.Text = "SpaceID";
            txtSpaceID.TextAlign = ContentAlignment.MiddleCenter;
            txtSpaceID.MouseClick += TableElement_Clicked;
            txtSpaceID.MouseEnter += TableElement_MouseHover;
            txtSpaceID.MouseLeave += TableElement_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 42, 53);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 39);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DeParkingSpacesRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "DeParkingSpacesRow";
            Size = new Size(420, 40);
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
        private Label txtStatus;
        private Label txtLotIdentifier;
        private Label txtSpaceID;
        private PictureBox pictureBox1;
    }
}
