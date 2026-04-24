namespace Valet_Parking_System.SubForms.OperatorWidgets
{
    partial class CarRetrievalWidget
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
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnCarRetrieved = new Button();
            CarRetrievalTableContentPanel = new FlowLayoutPanel();
            HeadingLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(CarRetrievalTableContentPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(HeadingLabel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(493, 717);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BtnCarRetrieved, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 617);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(453, 80);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // BtnCarRetrieved
            // 
            BtnCarRetrieved.BackColor = Color.FromArgb(8, 108, 236);
            BtnCarRetrieved.Dock = DockStyle.Fill;
            BtnCarRetrieved.Enabled = false;
            BtnCarRetrieved.FlatStyle = FlatStyle.Flat;
            BtnCarRetrieved.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCarRetrieved.ForeColor = Color.FromArgb(254, 254, 254);
            BtnCarRetrieved.Location = new Point(136, 20);
            BtnCarRetrieved.Margin = new Padding(0);
            BtnCarRetrieved.Name = "BtnCarRetrieved";
            BtnCarRetrieved.Size = new Size(180, 60);
            BtnCarRetrieved.TabIndex = 23;
            BtnCarRetrieved.Text = "Car Retrieved";
            BtnCarRetrieved.UseVisualStyleBackColor = false;
            BtnCarRetrieved.Click += BtnCarRetrieved_Click;
            // 
            // CarRetrievalTableContentPanel
            // 
            CarRetrievalTableContentPanel.AutoScroll = true;
            CarRetrievalTableContentPanel.AutoScrollMargin = new Size(20, 20);
            CarRetrievalTableContentPanel.BackColor = Color.FromArgb(228, 232, 233);
            CarRetrievalTableContentPanel.BorderStyle = BorderStyle.Fixed3D;
            CarRetrievalTableContentPanel.Dock = DockStyle.Fill;
            CarRetrievalTableContentPanel.Location = new Point(20, 100);
            CarRetrievalTableContentPanel.Margin = new Padding(0);
            CarRetrievalTableContentPanel.Name = "CarRetrievalTableContentPanel";
            CarRetrievalTableContentPanel.Size = new Size(453, 517);
            CarRetrievalTableContentPanel.TabIndex = 7;
            // 
            // HeadingLabel
            // 
            HeadingLabel.AutoSize = true;
            HeadingLabel.Dock = DockStyle.Fill;
            HeadingLabel.Font = new Font("Dubai Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadingLabel.ForeColor = Color.FromArgb(37, 42, 53);
            HeadingLabel.Location = new Point(20, 0);
            HeadingLabel.Margin = new Padding(0);
            HeadingLabel.Name = "HeadingLabel";
            HeadingLabel.Size = new Size(453, 100);
            HeadingLabel.TabIndex = 4;
            HeadingLabel.Text = "Car Retrieval";
            HeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CarRetrievalWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "CarRetrievalWidget";
            Size = new Size(493, 717);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeadingLabel;
        private FlowLayoutPanel CarRetrievalTableContentPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnCarRetrieved;
    }
}
