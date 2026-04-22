namespace Valet_Parking_System.SubForms.OperatorWidgets
{
    partial class CarStorageWidget
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
            BtnCarStored = new Button();
            CarStorageTableContentPanel = new FlowLayoutPanel();
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
            tableLayoutPanel1.Controls.Add(CarStorageTableContentPanel, 1, 1);
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BtnCarStored, 1, 1);
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
            // BtnCarStored
            // 
            BtnCarStored.BackColor = Color.FromArgb(8, 108, 236);
            BtnCarStored.Dock = DockStyle.Fill;
            BtnCarStored.FlatStyle = FlatStyle.Flat;
            BtnCarStored.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCarStored.ForeColor = Color.FromArgb(254, 254, 254);
            BtnCarStored.Location = new Point(136, 20);
            BtnCarStored.Margin = new Padding(0);
            BtnCarStored.Name = "BtnCarStored";
            BtnCarStored.Size = new Size(180, 60);
            BtnCarStored.TabIndex = 23;
            BtnCarStored.Text = "Car Stored";
            BtnCarStored.UseVisualStyleBackColor = false;
            BtnCarStored.Click += BtnCarStored_Click;
            // 
            // CarStorageTableContentPanel
            // 
            CarStorageTableContentPanel.AutoScroll = true;
            CarStorageTableContentPanel.AutoScrollMargin = new Size(20, 20);
            CarStorageTableContentPanel.BackColor = Color.FromArgb(228, 232, 233);
            CarStorageTableContentPanel.BorderStyle = BorderStyle.Fixed3D;
            CarStorageTableContentPanel.Dock = DockStyle.Fill;
            CarStorageTableContentPanel.Location = new Point(20, 100);
            CarStorageTableContentPanel.Margin = new Padding(0);
            CarStorageTableContentPanel.Name = "CarStorageTableContentPanel";
            CarStorageTableContentPanel.Size = new Size(453, 517);
            CarStorageTableContentPanel.TabIndex = 7;
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
            HeadingLabel.Text = "Car Storage";
            HeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CarStorageWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "CarStorageWidget";
            Size = new Size(493, 717);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeadingLabel;
        private FlowLayoutPanel CarStorageTableContentPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnCarStored;
    }
}
