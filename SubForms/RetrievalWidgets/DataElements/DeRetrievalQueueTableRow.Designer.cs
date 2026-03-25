namespace Valet_Parking_System.SubForms.BookingWidgets.DataElements
{
    partial class DeRetrievalQueueTableRow
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
            tableLayoutPanel3 = new TableLayoutPanel();
            txtRequestTime = new Label();
            txtSpace = new Label();
            txtRegistration = new Label();
            txtPosition = new Label();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000038F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(txtRequestTime, 1, 0);
            tableLayoutPanel3.Controls.Add(txtSpace, 3, 0);
            tableLayoutPanel3.Controls.Add(txtRegistration, 2, 0);
            tableLayoutPanel3.Controls.Add(txtPosition, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(960, 40);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // txtRequestTime
            // 
            txtRequestTime.AutoSize = true;
            txtRequestTime.BackColor = Color.FromArgb(238, 242, 243);
            txtRequestTime.Dock = DockStyle.Fill;
            txtRequestTime.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtRequestTime.ForeColor = Color.FromArgb(37, 42, 53);
            txtRequestTime.Location = new Point(240, 0);
            txtRequestTime.Margin = new Padding(0);
            txtRequestTime.Name = "txtRequestTime";
            txtRequestTime.Size = new Size(239, 40);
            txtRequestTime.TabIndex = 16;
            txtRequestTime.Text = "Request Time";
            txtRequestTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSpace
            // 
            txtSpace.AutoSize = true;
            txtSpace.BackColor = Color.FromArgb(238, 242, 243);
            txtSpace.Dock = DockStyle.Fill;
            txtSpace.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtSpace.ForeColor = Color.FromArgb(37, 42, 53);
            txtSpace.Location = new Point(718, 0);
            txtSpace.Margin = new Padding(0);
            txtSpace.Name = "txtSpace";
            txtSpace.Size = new Size(242, 40);
            txtSpace.TabIndex = 13;
            txtSpace.Text = "Space";
            txtSpace.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRegistration
            // 
            txtRegistration.AutoSize = true;
            txtRegistration.BackColor = Color.FromArgb(238, 242, 243);
            txtRegistration.Dock = DockStyle.Fill;
            txtRegistration.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtRegistration.ForeColor = Color.FromArgb(37, 42, 53);
            txtRegistration.Location = new Point(479, 0);
            txtRegistration.Margin = new Padding(0);
            txtRegistration.Name = "txtRegistration";
            txtRegistration.Size = new Size(239, 40);
            txtRegistration.TabIndex = 12;
            txtRegistration.Text = "Registration";
            txtRegistration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            txtPosition.AutoSize = true;
            txtPosition.BackColor = Color.FromArgb(238, 242, 243);
            txtPosition.Dock = DockStyle.Fill;
            txtPosition.Font = new Font("Dubai Medium", 8F, FontStyle.Bold);
            txtPosition.ForeColor = Color.FromArgb(37, 42, 53);
            txtPosition.Location = new Point(0, 0);
            txtPosition.Margin = new Padding(0);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(240, 40);
            txtPosition.TabIndex = 10;
            txtPosition.Text = "Position";
            txtPosition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeRetrievalQueueTableRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Margin = new Padding(0);
            MaximumSize = new Size(960, 40);
            MinimumSize = new Size(960, 40);
            Name = "DeRetrievalQueueTableRow";
            Size = new Size(960, 40);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label txtRequestTime;
        private Label txtSpace;
        private Label txtRegistration;
        private Label txtPosition;
    }
}
