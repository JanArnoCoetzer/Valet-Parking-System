namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    partial class DEAwaitingOwnerTableRow
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
            tableLayoutPanel3 = new TableLayoutPanel();
            txtNumber = new Label();
            txtOwnerFullname = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtCarDiscription = new Label();
            txtCarRegistration = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            BackPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(420, 60);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 1;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BackPanel.Controls.Add(tableLayoutPanel3, 0, 1);
            BackPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 2;
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BackPanel.Size = new Size(420, 59);
            BackPanel.TabIndex = 3;
            BackPanel.Click += TableElement_Clicked;
            BackPanel.MouseEnter += TableElement_MouseHover;
            BackPanel.MouseLeave += TableElement_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(txtNumber, 1, 0);
            tableLayoutPanel3.Controls.Add(txtOwnerFullname, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 32);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(414, 24);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Click += TableElement_Clicked;
            tableLayoutPanel3.MouseEnter += TableElement_MouseHover;
            tableLayoutPanel3.MouseLeave += TableElement_MouseLeave;
            // 
            // txtNumber
            // 
            txtNumber.AutoSize = true;
            txtNumber.BackColor = Color.Transparent;
            txtNumber.Dock = DockStyle.Fill;
            txtNumber.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtNumber.ForeColor = Color.FromArgb(37, 42, 53);
            txtNumber.Location = new Point(117, 0);
            txtNumber.Margin = new Padding(0);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(297, 24);
            txtNumber.TabIndex = 15;
            txtNumber.Text = "OwnerNumber";
            txtNumber.TextAlign = ContentAlignment.MiddleLeft;
            txtNumber.Click += TableElement_Clicked;
            txtNumber.MouseEnter += TableElement_MouseHover;
            txtNumber.MouseLeave += TableElement_MouseLeave;
            // 
            // txtOwnerFullname
            // 
            txtOwnerFullname.AutoSize = true;
            txtOwnerFullname.BackColor = Color.Transparent;
            txtOwnerFullname.Dock = DockStyle.Fill;
            txtOwnerFullname.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtOwnerFullname.ForeColor = Color.FromArgb(37, 42, 53);
            txtOwnerFullname.Location = new Point(0, 0);
            txtOwnerFullname.Margin = new Padding(0);
            txtOwnerFullname.Name = "txtOwnerFullname";
            txtOwnerFullname.Size = new Size(117, 24);
            txtOwnerFullname.TabIndex = 14;
            txtOwnerFullname.Text = "OwnerName";
            txtOwnerFullname.TextAlign = ContentAlignment.MiddleLeft;
            txtOwnerFullname.Click += TableElement_Clicked;
            txtOwnerFullname.MouseEnter += TableElement_MouseHover;
            txtOwnerFullname.MouseLeave += TableElement_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(txtCarDiscription, 1, 0);
            tableLayoutPanel2.Controls.Add(txtCarRegistration, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(414, 23);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Click += TableElement_Clicked;
            tableLayoutPanel2.MouseEnter += TableElement_MouseHover;
            tableLayoutPanel2.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarDiscription
            // 
            txtCarDiscription.AutoSize = true;
            txtCarDiscription.BackColor = Color.Transparent;
            txtCarDiscription.Dock = DockStyle.Fill;
            txtCarDiscription.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtCarDiscription.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarDiscription.Location = new Point(147, 0);
            txtCarDiscription.Margin = new Padding(0);
            txtCarDiscription.Name = "txtCarDiscription";
            txtCarDiscription.Size = new Size(267, 23);
            txtCarDiscription.TabIndex = 15;
            txtCarDiscription.Text = "CarDescription";
            txtCarDiscription.TextAlign = ContentAlignment.MiddleLeft;
            txtCarDiscription.Click += TableElement_Clicked;
            txtCarDiscription.MouseEnter += TableElement_MouseHover;
            txtCarDiscription.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarRegistration
            // 
            txtCarRegistration.AutoSize = true;
            txtCarRegistration.BackColor = Color.Transparent;
            txtCarRegistration.Dock = DockStyle.Fill;
            txtCarRegistration.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtCarRegistration.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarRegistration.Location = new Point(0, 0);
            txtCarRegistration.Margin = new Padding(0);
            txtCarRegistration.Name = "txtCarRegistration";
            txtCarRegistration.Size = new Size(147, 23);
            txtCarRegistration.TabIndex = 14;
            txtCarRegistration.Text = "CarRegistration";
            txtCarRegistration.TextAlign = ContentAlignment.MiddleLeft;
            txtCarRegistration.Click += TableElement_Clicked;
            txtCarRegistration.MouseEnter += TableElement_MouseHover;
            txtCarRegistration.MouseLeave += TableElement_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 42, 53);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 59);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DEAwaitingOwnerTableRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "DEAwaitingOwnerTableRow";
            Size = new Size(420, 60);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            BackPanel.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel BackPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label txtCarRegistration;
        private Label txtCarDiscription;
        private TableLayoutPanel tableLayoutPanel3;
        private Label txtNumber;
        private Label txtOwnerFullname;
    }
}
