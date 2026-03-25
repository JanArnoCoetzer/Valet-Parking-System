using System.Windows.Forms;

namespace Valet_Parking_System.SubForms
{
    partial class BookingSubForm
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            SearchBookingsWidget = new Valet_Parking_System.SubForms.BookingWidgets.BookingSearchBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            NewBookingWidget = new Valet_Parking_System.SubForms.BookingWidgets.AddBooking();
            BookingTableWidget = new Valet_Parking_System.SubForms.BookingWidgets.BookingsTable();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(SearchBookingsWidget, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel2.Controls.Add(BookingTableWidget, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 20);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(1520, 717);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // SearchBookingsWidget
            // 
            SearchBookingsWidget.Dock = DockStyle.Fill;
            SearchBookingsWidget.Location = new Point(0, 0);
            SearchBookingsWidget.Margin = new Padding(0);
            SearchBookingsWidget.Name = "SearchBookingsWidget";
            SearchBookingsWidget.Size = new Size(1000, 139);
            SearchBookingsWidget.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(NewBookingWidget, 0, 0);
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
            // NewBookingWidget
            // 
            NewBookingWidget.BackColor = Color.FromArgb(228, 232, 233);
            NewBookingWidget.Dock = DockStyle.Fill;
            NewBookingWidget.Location = new Point(0, 0);
            NewBookingWidget.Margin = new Padding(0);
            NewBookingWidget.Name = "NewBookingWidget";
            NewBookingWidget.Size = new Size(500, 717);
            NewBookingWidget.TabIndex = 0;
            // 
            // BookingTableWidget
            // 
            BookingTableWidget.Location = new Point(0, 159);
            BookingTableWidget.Margin = new Padding(0);
            BookingTableWidget.Name = "BookingTableWidget";
            BookingTableWidget.Size = new Size(1000, 558);
            BookingTableWidget.TabIndex = 3;
            // 
            // BookingSubForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 232, 233);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "BookingSubForm";
            Size = new Size(1560, 757);
            Load += BookingSubForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private BookingWidgets.BookingSearchBar SearchBookingsWidget;       
        private TableLayoutPanel tableLayoutPanel3;      
        private BookingWidgets.AddBooking NewBookingWidget;
        private BookingWidgets.BookingsTable bookingsTable1;
        private BookingWidgets.BookingsTable BookingTableWidget;
    }
}