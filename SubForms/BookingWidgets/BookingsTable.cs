
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingsTable : UserControl
    {
        EditBookingWindow1 editBookingWindow;
        Booking selectedBooking;
        BookingSubForm parentForm;
        bool BookingSelected = false;
        
        private FlowLayoutPanel TableContentPanel => this.BookingsTableContentPanel;   
             
        public BookingsTable(List<Booking> bookings)
        {
            InitializeComponent();
            InitialiseRoundedBorders();          
        }

        //public parameterless constructor 
        public BookingsTable() : this(null)
        {
        }

        public void setparentform(BookingSubForm parent) 
        {
            this.parentForm = parent;
        }

        public void EditBooking(Booking booking) 
        {
            parentForm.EditBooking(booking);
        }
        public async void DisplayBookings(List<Booking> bookings)
        {
            //chunk based table population to avoid creating error handle overflow
            try
            {
                TableContentPanel.Controls.Clear();

                if (bookings == null || bookings.Count == 0)
                    return;

                const int chunkSize = 20;  
                int totalChunks = (bookings.Count + chunkSize - 1) / chunkSize;

                for (int chunk = 0; chunk < totalChunks; chunk++)
                {
                    int start = chunk * chunkSize;
                    int end = Math.Min(start + chunkSize, bookings.Count);

                    for (int i = start; i < end; i++)
                    {
                        var booking = bookings[i];
                        bool isDarkRow = i % 2 == 0;
                        var row = new DeBookingTableRow(booking, this, isDarkRow);
                        TableContentPanel.Controls.Add(row);
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DisplayBookings failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-----------------------------ExternalCalls-----------------------------
        public void DeselectAllElements() 
        {
            foreach (Control c in TableContentPanel.Controls)
            {
                if (c is DeBookingTableRow row)
                    row.Deselect();
            }
        }
        public void selectedElement(Booking booking) 
        {
            selectedBooking = booking;
            BookingSelected = true; 
        }

        //-----------------------------Events-----------------------------
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (selectedBooking != null)  
            {
                editBookingWindow?.Close();
                editBookingWindow?.Dispose();
                editBookingWindow = new EditBookingWindow1(this, selectedBooking);
                editBookingWindow.StartPosition = FormStartPosition.CenterScreen;
                editBookingWindow.ShowDialog();               
                editBookingWindow = null;
            }
        }

        public void CancelEditBooking()
        {
            editBookingWindow?.Close();
            editBookingWindow?.Dispose();
            editBookingWindow = null;
        }

        private void BtnMarkForRetrieval_Click(object sender, EventArgs e)
        {
            RetrievalQueueItem item = new RetrievalQueueItem(selectedBooking, 0,"pending");
            parentForm.requestPickup(item);
        }





























        ///-----------------------------Rendering-----------------------------
        private void InitialiseRoundedBorders()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        
    }
}
