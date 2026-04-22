namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    partial class DeCarRetrievalTableRow
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
            BackPanel = new TableLayoutPanel();
            txtCarRegistration = new Label();
            label1 = new Label();
            txtToArea = new Label();
            txtFromArea = new Label();
            txtCarDiscription = new Label();
            BackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackPanel
            // 
            BackPanel.AutoSize = true;
            BackPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackPanel.BackColor = Color.FromArgb(228, 232, 233);
            BackPanel.ColumnCount = 6;
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle());
            BackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BackPanel.Controls.Add(txtCarRegistration, 3, 0);
            BackPanel.Controls.Add(label1, 2, 1);
            BackPanel.Controls.Add(txtToArea, 3, 1);
            BackPanel.Controls.Add(txtFromArea, 1, 1);
            BackPanel.Controls.Add(txtCarDiscription, 1, 0);
            BackPanel.Dock = DockStyle.Fill;
            BackPanel.Location = new Point(0, 0);
            BackPanel.Margin = new Padding(0);
            BackPanel.Name = "BackPanel";
            BackPanel.RowCount = 3;
            BackPanel.RowStyles.Add(new RowStyle());
            BackPanel.RowStyles.Add(new RowStyle());
            BackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackPanel.Size = new Size(420, 59);
            BackPanel.TabIndex = 5;
            BackPanel.Click += TableElement_Clicked;
            BackPanel.MouseEnter += TableElement_MouseHover;
            BackPanel.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarRegistration
            // 
            txtCarRegistration.AutoSize = true;
            txtCarRegistration.BackColor = Color.Transparent;
            txtCarRegistration.Dock = DockStyle.Fill;
            txtCarRegistration.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtCarRegistration.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarRegistration.Location = new Point(219, 0);
            txtCarRegistration.Margin = new Padding(0);
            txtCarRegistration.Name = "txtCarRegistration";
            txtCarRegistration.Size = new Size(152, 30);
            txtCarRegistration.TabIndex = 16;
            txtCarRegistration.Text = "CarRegestration";
            txtCarRegistration.TextAlign = ContentAlignment.MiddleLeft;
            txtCarRegistration.Click += TableElement_Clicked;
            txtCarRegistration.MouseEnter += TableElement_MouseHover;
            txtCarRegistration.MouseLeave += TableElement_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(37, 42, 53);
            label1.Location = new Point(187, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(32, 30);
            label1.TabIndex = 15;
            label1.Text = "->";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += TableElement_Clicked;
            label1.MouseEnter += TableElement_MouseHover;
            label1.MouseLeave += TableElement_MouseLeave;
            // 
            // txtToArea
            // 
            txtToArea.AutoSize = true;
            txtToArea.BackColor = Color.Transparent;
            txtToArea.Dock = DockStyle.Fill;
            txtToArea.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtToArea.ForeColor = Color.FromArgb(37, 42, 53);
            txtToArea.Location = new Point(219, 30);
            txtToArea.Margin = new Padding(0);
            txtToArea.Name = "txtToArea";
            txtToArea.Size = new Size(152, 30);
            txtToArea.TabIndex = 14;
            txtToArea.Text = "To Area";
            txtToArea.TextAlign = ContentAlignment.MiddleLeft;
            txtToArea.Click += TableElement_Clicked;
            txtToArea.MouseEnter += TableElement_MouseHover;
            txtToArea.MouseLeave += TableElement_MouseLeave;
            // 
            // txtFromArea
            // 
            txtFromArea.AutoSize = true;
            txtFromArea.BackColor = Color.Transparent;
            txtFromArea.Dock = DockStyle.Fill;
            txtFromArea.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtFromArea.ForeColor = Color.FromArgb(37, 42, 53);
            txtFromArea.Location = new Point(48, 30);
            txtFromArea.Margin = new Padding(0);
            txtFromArea.Name = "txtFromArea";
            txtFromArea.Size = new Size(139, 30);
            txtFromArea.TabIndex = 13;
            txtFromArea.Text = "From Area";
            txtFromArea.TextAlign = ContentAlignment.MiddleRight;
            txtFromArea.Click += TableElement_Clicked;
            txtFromArea.MouseEnter += TableElement_MouseHover;
            txtFromArea.MouseLeave += TableElement_MouseLeave;
            // 
            // txtCarDiscription
            // 
            txtCarDiscription.AutoSize = true;
            txtCarDiscription.BackColor = Color.Transparent;
            txtCarDiscription.Dock = DockStyle.Fill;
            txtCarDiscription.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold);
            txtCarDiscription.ForeColor = Color.FromArgb(37, 42, 53);
            txtCarDiscription.Location = new Point(48, 0);
            txtCarDiscription.Margin = new Padding(0);
            txtCarDiscription.Name = "txtCarDiscription";
            txtCarDiscription.Size = new Size(139, 30);
            txtCarDiscription.TabIndex = 12;
            txtCarDiscription.Text = "CarDescription";
            txtCarDiscription.TextAlign = ContentAlignment.MiddleLeft;
            txtCarDiscription.Click += TableElement_Clicked;
            txtCarDiscription.MouseEnter += TableElement_MouseHover;
            txtCarDiscription.MouseLeave += TableElement_MouseLeave;
            // 
            // DeCarRetrievalTableRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackPanel);
            Margin = new Padding(0);
            Name = "DeCarRetrievalTableRow";
            Size = new Size(420, 59);
            BackPanel.ResumeLayout(false);
            BackPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel BackPanel;
        private Label txtCarRegistration;
        private Label label1;
        private Label txtToArea;
        private Label txtFromArea;
        private Label txtCarDiscription;
    }
}
