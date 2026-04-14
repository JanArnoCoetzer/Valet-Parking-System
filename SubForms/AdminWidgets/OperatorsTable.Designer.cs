namespace Valet_Parking_System.SubForms.AdminWidgets
{
    partial class OperatorsTable
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
            tableLayoutPanel3 = new TableLayoutPanel();
            OperatorsTableContentPanel = new FlowLayoutPanel();
            HeadingLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnAddOperator = new Button();
            BtnEditOperator = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(HeadingLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(493, 717);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(OperatorsTableContentPanel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 80);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(493, 557);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // OperatorsTableContentPanel
            // 
            OperatorsTableContentPanel.AutoScroll = true;
            OperatorsTableContentPanel.BackColor = Color.FromArgb(228, 232, 233);
            OperatorsTableContentPanel.BorderStyle = BorderStyle.Fixed3D;
            OperatorsTableContentPanel.Dock = DockStyle.Fill;
            OperatorsTableContentPanel.Location = new Point(20, 0);
            OperatorsTableContentPanel.Margin = new Padding(0);
            OperatorsTableContentPanel.Name = "OperatorsTableContentPanel";
            OperatorsTableContentPanel.Size = new Size(453, 557);
            OperatorsTableContentPanel.TabIndex = 6;
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
            HeadingLabel.Text = "Manage Operators";
            HeadingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(BtnAddOperator, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnEditOperator, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 657);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(493, 60);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnAddOperator
            // 
            BtnAddOperator.BackColor = Color.FromArgb(8, 108, 236);
            BtnAddOperator.Dock = DockStyle.Fill;
            BtnAddOperator.FlatStyle = FlatStyle.Flat;
            BtnAddOperator.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAddOperator.ForeColor = Color.FromArgb(254, 254, 254);
            BtnAddOperator.Location = new Point(246, 0);
            BtnAddOperator.Margin = new Padding(0);
            BtnAddOperator.Name = "BtnAddOperator";
            BtnAddOperator.Size = new Size(247, 60);
            BtnAddOperator.TabIndex = 8;
            BtnAddOperator.Text = "Add Operator";
            BtnAddOperator.UseVisualStyleBackColor = false;
            BtnAddOperator.Click += BtnAddOperator_Click;
            // 
            // BtnEditOperator
            // 
            BtnEditOperator.BackColor = Color.FromArgb(8, 108, 236);
            BtnEditOperator.Dock = DockStyle.Fill;
            BtnEditOperator.FlatStyle = FlatStyle.Flat;
            BtnEditOperator.Font = new Font("Dubai", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEditOperator.ForeColor = Color.FromArgb(254, 254, 254);
            BtnEditOperator.Location = new Point(0, 0);
            BtnEditOperator.Margin = new Padding(0);
            BtnEditOperator.Name = "BtnEditOperator";
            BtnEditOperator.Size = new Size(246, 60);
            BtnEditOperator.TabIndex = 7;
            BtnEditOperator.Text = "Edit Operator";
            BtnEditOperator.UseVisualStyleBackColor = false;
            BtnEditOperator.Click += BtnEditOperator_Click;
            // 
            // OperatorsTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 254);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "OperatorsTable";
            Size = new Size(493, 717);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label HeadingLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnEditOperator;
        private Button BtnAddOperator;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel OperatorsTableContentPanel;
    }
}
