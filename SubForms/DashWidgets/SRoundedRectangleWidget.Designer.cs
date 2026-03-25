namespace Valet_Parking_System.SubForms.Widgets
{
    partial class RoundedWidget
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
            ValueLabel = new Label();
            HeadingLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(ValueLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(HeadingLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Size = new Size(420, 194);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ValueLabel
            // 
            ValueLabel.AutoSize = true;
            ValueLabel.Dock = DockStyle.Fill;
            ValueLabel.Font = new Font("Dubai", 47.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValueLabel.ForeColor = Color.FromArgb(8, 108, 236);
            ValueLabel.Location = new Point(0, 48);
            ValueLabel.Margin = new Padding(0);
            ValueLabel.Name = "ValueLabel";
            ValueLabel.Size = new Size(420, 146);
            ValueLabel.TabIndex = 1;
            ValueLabel.Text = "999";
            ValueLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            HeadingLabel.Size = new Size(420, 48);
            HeadingLabel.TabIndex = 0;
            HeadingLabel.Text = "Heading";
            HeadingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoundedWidget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "RoundedWidget";
            Size = new Size(420, 194);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ValueLabel;
        private Label HeadingLabel;
    }
}
