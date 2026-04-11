namespace Valet_Parking_System.SubForms.AdminWidgets
{
    partial class ParkingSpacesTable
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
            HeadingLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnAddSpace = new Button();
            BtnEditSpace = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            ParkingSpacesTableContentPanel = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtboxLotIdentifier = new TextBox();
            txtBoxSpaceID = new Label();
            StatusBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(HeadingLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(493, 717);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Dock = DockStyle.Fill;
            HeadingLabel.Font = new Font("Dubai Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadingLabel.ForeColor = Color.FromArgb(37, 42, 53);
            HeadingLabel.Location = new Point(0, 0);
            HeadingLabel.Margin = new Padding(0);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(493, 60);
            HeadingLabel.TabIndex = 2;
            HeadingLabel.Text = "Manage Parking Spaces";
            HeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(BtnAddSpace, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnEditSpace, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 657);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(493, 60);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnAddSpace
            // 
            BtnAddSpace.BackColor = Color.FromArgb(8, 108, 236);
            BtnAddSpace.Dock = DockStyle.Fill;
            BtnAddSpace.FlatStyle = FlatStyle.Flat;
            BtnAddSpace.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddSpace.ForeColor = Color.FromArgb(254, 254, 254);
            BtnAddSpace.Location = new Point(246, 0);
            BtnAddSpace.Margin = new Padding(0);
            BtnAddSpace.Name = "BtnAddSpace";
            BtnAddSpace.Size = new Size(247, 60);
            BtnAddSpace.TabIndex = 7;
            BtnAddSpace.Text = "Add Space";
            BtnAddSpace.UseVisualStyleBackColor = false;
            BtnAddSpace.Click += BtnAddSpace_Click;
            // 
            // BtnEditSpace
            // 
            BtnEditSpace.BackColor = Color.FromArgb(8, 108, 236);
            BtnEditSpace.Dock = DockStyle.Fill;
            BtnEditSpace.FlatStyle = FlatStyle.Flat;
            BtnEditSpace.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditSpace.ForeColor = Color.FromArgb(254, 254, 254);
            BtnEditSpace.Location = new Point(0, 0);
            BtnEditSpace.Margin = new Padding(0);
            BtnEditSpace.Name = "BtnEditSpace";
            BtnEditSpace.Size = new Size(246, 60);
            BtnEditSpace.TabIndex = 6;
            BtnEditSpace.Text = "Edit Space";
            BtnEditSpace.UseVisualStyleBackColor = false;
            BtnEditSpace.Click += BtnEditSpace_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(ParkingSpacesTableContentPanel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 120);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(493, 517);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // ParkingSpacesTableContentPanel
            // 
            ParkingSpacesTableContentPanel.AutoScroll = true;
            ParkingSpacesTableContentPanel.BackColor = Color.FromArgb(228, 232, 233);
            ParkingSpacesTableContentPanel.BorderStyle = BorderStyle.Fixed3D;
            ParkingSpacesTableContentPanel.Dock = DockStyle.Fill;
            ParkingSpacesTableContentPanel.Location = new Point(20, 0);
            ParkingSpacesTableContentPanel.Margin = new Padding(0);
            ParkingSpacesTableContentPanel.Name = "ParkingSpacesTableContentPanel";
            ParkingSpacesTableContentPanel.Size = new Size(453, 517);
            ParkingSpacesTableContentPanel.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 60);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(493, 40);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6600437F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.56512F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(txtboxLotIdentifier, 1, 0);
            tableLayoutPanel5.Controls.Add(txtBoxSpaceID, 0, 0);
            tableLayoutPanel5.Controls.Add(StatusBox, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(20, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(453, 40);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // txtboxLotIdentifier
            // 
            txtboxLotIdentifier.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtboxLotIdentifier.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxLotIdentifier.ForeColor = Color.FromArgb(37, 42, 53);
            txtboxLotIdentifier.Location = new Point(80, 0);
            txtboxLotIdentifier.Margin = new Padding(0);
            txtboxLotIdentifier.Name = "txtboxLotIdentifier";
            txtboxLotIdentifier.PlaceholderText = "LotIdentifier";
            txtboxLotIdentifier.Size = new Size(220, 41);
            txtboxLotIdentifier.TabIndex = 13;
            // 
            // txtBoxSpaceID
            // 
            txtBoxSpaceID.AutoSize = true;
            txtBoxSpaceID.BackColor = Color.Transparent;
            txtBoxSpaceID.Dock = DockStyle.Fill;
            txtBoxSpaceID.Font = new Font("Dubai", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxSpaceID.ForeColor = Color.FromArgb(37, 42, 53);
            txtBoxSpaceID.Location = new Point(0, 0);
            txtBoxSpaceID.Margin = new Padding(0);
            txtBoxSpaceID.Name = "txtBoxSpaceID";
            txtBoxSpaceID.Size = new Size(80, 40);
            txtBoxSpaceID.TabIndex = 12;
            txtBoxSpaceID.Text = "SpaceID";
            txtBoxSpaceID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StatusBox
            // 
            StatusBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "Available", "Occupied", "Out of Service" });
            StatusBox.Location = new Point(303, 3);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(147, 33);
            StatusBox.TabIndex = 14;
            StatusBox.Text = "Available";
            // 
            // ParkingSpacesTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "ParkingSpacesTable";
            Size = new Size(493, 717);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeadingLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnAddSpace;
        private Button BtnEditSpace;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel ParkingSpacesTableContentPanel;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label txtBoxSpaceID;
        private TextBox txtboxLotIdentifier;
        private ComboBox StatusBox;
    }
}
