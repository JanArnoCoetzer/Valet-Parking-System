namespace Valet_Parking_System.SubForms
{
    partial class RetrievalQueueSubForm
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
            tableLayoutPanel3 = new TableLayoutPanel();
            selectedEntryWidget1 = new Valet_Parking_System.SubForms.RetrievalWidgets.SelectedEntryWidget();
            retrievalQueueSearchBar1 = new Valet_Parking_System.SubForms.RetrievalWidgets.RetrievalQueueSearchBar();
            retrievalTable = new Valet_Parking_System.SubForms.RetrievalWidgets.RetrievalTable();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Controls.Add(retrievalQueueSearchBar1, 0, 0);
            tableLayoutPanel2.Controls.Add(retrievalTable, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(1520, 717);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(selectedEntryWidget1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1020, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(500, 717);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // selectedEntryWidget1
            // 
            selectedEntryWidget1.Location = new Point(0, 0);
            selectedEntryWidget1.Margin = new Padding(0);
            selectedEntryWidget1.Name = "selectedEntryWidget1";
            selectedEntryWidget1.Size = new Size(500, 717);
            selectedEntryWidget1.TabIndex = 0;
            // 
            // retrievalQueueSearchBar1
            // 
            retrievalQueueSearchBar1.Location = new Point(0, 0);
            retrievalQueueSearchBar1.Margin = new Padding(0);
            retrievalQueueSearchBar1.Name = "retrievalQueueSearchBar1";
            retrievalQueueSearchBar1.Size = new Size(1000, 139);
            retrievalQueueSearchBar1.TabIndex = 3;
            // 
            // retrievalTable
            // 
            retrievalTable.Location = new Point(0, 159);
            retrievalTable.Margin = new Padding(0);
            retrievalTable.Name = "retrievalTable";
            retrievalTable.Size = new Size(1000, 558);
            retrievalTable.TabIndex = 4;
            // 
            // RetrievalQueueSubForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "RetrievalQueueSubForm";
            Size = new Size(1560, 757);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private RetrievalWidgets.RetrievalQueueSearchBar retrievalQueueSearchBar1;
        private RetrievalWidgets.RetrievalTable retrievalTable;
        private RetrievalWidgets.SelectedEntryWidget selectedEntryWidget1;
    }
}
