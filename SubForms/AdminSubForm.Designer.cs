namespace Valet_Parking_System.SubForms
{
    partial class AdminSubForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            parkingSpacesTable = new Valet_Parking_System.SubForms.AdminWidgets.ParkingSpacesTable();
            operatorsTable1 = new Valet_Parking_System.SubForms.AdminWidgets.OperatorsTable();
            analyticsWidget1 = new Valet_Parking_System.SubForms.AdminWidgets.AnalyticsWidget();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1560, 757);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(parkingSpacesTable, 0, 0);
            tableLayoutPanel2.Controls.Add(operatorsTable1, 2, 0);
            tableLayoutPanel2.Controls.Add(analyticsWidget1, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1520, 717);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // parkingSpacesTable
            // 
            parkingSpacesTable.BackColor = Color.FromArgb(254, 254, 254);
            parkingSpacesTable.Location = new Point(0, 0);
            parkingSpacesTable.Margin = new Padding(0);
            parkingSpacesTable.Name = "parkingSpacesTable";
            parkingSpacesTable.Size = new Size(493, 717);
            parkingSpacesTable.TabIndex = 0;
            // 
            // operatorsTable1
            // 
            operatorsTable1.BackColor = Color.FromArgb(254, 254, 254);
            operatorsTable1.Location = new Point(513, 0);
            operatorsTable1.Margin = new Padding(0);
            operatorsTable1.Name = "operatorsTable1";
            operatorsTable1.Size = new Size(493, 717);
            operatorsTable1.TabIndex = 1;
            // 
            // analyticsWidget1
            // 
            analyticsWidget1.Location = new Point(1026, 0);
            analyticsWidget1.Margin = new Padding(0);
            analyticsWidget1.Name = "analyticsWidget1";
            analyticsWidget1.Size = new Size(494, 717);
            analyticsWidget1.TabIndex = 2;
            // 
            // AdminSubForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "AdminSubForm";
            Size = new Size(1560, 757);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private AdminWidgets.ParkingSpacesTable parkingSpacesTable;
        private AdminWidgets.OperatorsTable operatorsTable1;
        private AdminWidgets.AnalyticsWidget analyticsWidget1;
    }
}