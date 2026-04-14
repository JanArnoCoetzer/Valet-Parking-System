namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    partial class DeOperatorsRow
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
            txtFullName = new Label();
            txtOperatorID = new Label();
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 2;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            BackPanel.Controls.Add(txtFullName, 1, 0);
            BackPanel.Controls.Add(txtOperatorID, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 1;
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(420, 39);
            BackPanel.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.BackColor = Color.Transparent;
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtFullName.ForeColor = Color.FromArgb(37, 42, 53);
            txtFullName.Location = new Point(139, 0);
            txtFullName.Margin = new Padding(0);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(281, 39);
            txtFullName.TabIndex = 17;
            txtFullName.Text = "FullName";
            txtFullName.TextAlign = ContentAlignment.MiddleCenter;
            txtFullName.Click += TableElement_Clicked;
            txtFullName.MouseEnter += TableElement_MouseHover;
            txtFullName.MouseLeave += TableElement_MouseLeave;
            // 
            // txtOperatorID
            // 
            txtOperatorID.AutoSize = true;
            txtOperatorID.BackColor = Color.Transparent;
            txtOperatorID.Dock = DockStyle.Fill;
            txtOperatorID.Font = new Font("Dubai", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOperatorID.ForeColor = Color.FromArgb(37, 42, 53);
            txtOperatorID.Location = new Point(0, 0);
            txtOperatorID.Margin = new Padding(0);
            txtOperatorID.Name = "txtOperatorID";
            txtOperatorID.Size = new Size(139, 39);
            txtOperatorID.TabIndex = 11;
            txtOperatorID.Text = "OperatorID";
            txtOperatorID.TextAlign = ContentAlignment.MiddleCenter;
            txtOperatorID.Click += TableElement_Clicked;
            txtOperatorID.MouseEnter += TableElement_MouseHover;
            txtOperatorID.MouseLeave += TableElement_MouseLeave;
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
            // DeOperatorsRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "DeOperatorsRow";
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
        private Label txtFullName;
        private Label txtOperatorID;
        private PictureBox pictureBox1;
    }
}
