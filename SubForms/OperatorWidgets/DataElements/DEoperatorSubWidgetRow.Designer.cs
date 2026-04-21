namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    partial class DEoperatorSubWidgetRow
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
            label2 = new Label();
            txtCarRegistration = new Label();
            label1 = new Label();
            txtToArea = new Label();
            txtFromArea = new Label();
            txtCarDiscription = new Label();
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
            tableLayoutPanel1.Size = new Size(670, 79);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 5;
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BackPanel.Controls.Add(label2, 1, 0);
            BackPanel.Controls.Add(txtCarRegistration, 2, 0);
            BackPanel.Controls.Add(label1, 1, 1);
            BackPanel.Controls.Add(txtToArea, 2, 1);
            BackPanel.Controls.Add(txtFromArea, 0, 1);
            BackPanel.Controls.Add(txtCarDiscription, 0, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 3;
            BackPanel.RowStyles.Add(new RowStyle());
            BackPanel.RowStyles.Add(new RowStyle());
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(670, 78);
            BackPanel.TabIndex = 3;
            BackPanel.MouseEnter += TableElement_MouseHover;
            BackPanel.MouseLeave += TableElement_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Dubai Medium", 10.999999F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(37, 42, 53);
            label2.Location = new Point(167, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 17;
            label2.Text = "With Registration:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.MouseEnter += TableElement_MouseHover;
            label2.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarRegistration
            // 
            txtCarRegistration.AutoSize = true;
            txtCarRegistration.BackColor = Color.Transparent;
            txtCarRegistration.Dock = DockStyle.Fill;
            txtCarRegistration.Font = new Font("Dubai", 10.999999F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtCarRegistration.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarRegistration.Location = new Point(367, 0);
            txtCarRegistration.Margin = new Padding(0);
            txtCarRegistration.Name = "txtCarRegistration";
            txtCarRegistration.Size = new Size(171, 37);
            txtCarRegistration.TabIndex = 16;
            txtCarRegistration.Text = "CarRegestration";
            txtCarRegistration.TextAlign = ContentAlignment.MiddleLeft;
            txtCarRegistration.MouseEnter += TableElement_MouseHover;
            txtCarRegistration.MouseLeave += TableElement_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Dubai Medium", 10.999999F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 42, 53);
            label1.Location = new Point(167, 37);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(200, 37);
            label1.TabIndex = 15;
            label1.Text = "Going To";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseEnter += TableElement_MouseHover;
            label1.MouseLeave += TableElement_MouseLeave;
            // 
            // txtToArea
            // 
            txtToArea.AutoSize = true;
            txtToArea.BackColor = Color.Transparent;
            txtToArea.Dock = DockStyle.Fill;
            txtToArea.Font = new Font("Dubai", 10.999999F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtToArea.ForeColor = Color.FromArgb(37, 42, 53);
            txtToArea.Location = new Point(367, 37);
            txtToArea.Margin = new Padding(0);
            txtToArea.Name = "txtToArea";
            txtToArea.Size = new Size(171, 37);
            txtToArea.TabIndex = 14;
            txtToArea.Text = "To Area";
            txtToArea.TextAlign = ContentAlignment.MiddleLeft;
            txtToArea.MouseEnter += TableElement_MouseHover;
            txtToArea.MouseLeave += TableElement_MouseLeave;
            // 
            // txtFromArea
            // 
            txtFromArea.AutoSize = true;
            txtFromArea.BackColor = Color.Transparent;
            txtFromArea.Dock = DockStyle.Fill;
            txtFromArea.Font = new Font("Dubai Medium", 10.999999F, FontStyle.Bold);
            txtFromArea.ForeColor = Color.FromArgb(37, 42, 53);
            txtFromArea.Location = new Point(0, 37);
            txtFromArea.Margin = new Padding(0);
            txtFromArea.Name = "txtFromArea";
            txtFromArea.Size = new Size(167, 37);
            txtFromArea.TabIndex = 13;
            txtFromArea.Text = "From Area";
            txtFromArea.TextAlign = ContentAlignment.MiddleRight;
            txtFromArea.MouseEnter += TableElement_MouseHover;
            txtFromArea.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarDiscription
            // 
            txtCarDiscription.AutoSize = true;
            txtCarDiscription.BackColor = Color.Transparent;
            txtCarDiscription.Dock = DockStyle.Fill;
            txtCarDiscription.Font = new Font("Dubai Medium", 10.999999F, FontStyle.Bold);
            txtCarDiscription.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarDiscription.Location = new Point(0, 0);
            txtCarDiscription.Margin = new Padding(0);
            txtCarDiscription.Name = "txtCarDiscription";
            txtCarDiscription.Size = new Size(167, 37);
            txtCarDiscription.TabIndex = 12;
            txtCarDiscription.Text = "CarDescription";
            txtCarDiscription.TextAlign = ContentAlignment.MiddleLeft;
            txtCarDiscription.MouseEnter += TableElement_MouseHover;
            txtCarDiscription.MouseLeave += TableElement_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(37, 42, 53);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 78);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 1);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DEoperatorSubWidgetRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "DEoperatorSubWidgetRow";
            Size = new Size(670, 79);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            BackPanel.ResumeLayout(false);
            BackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel BackPanel;
        private Label label1;
        private Label txtToArea;
        private Label txtFromArea;
        private Label txtCarDiscription;
        private Label label2;
        private Label txtCarRegistration;
    }
}
