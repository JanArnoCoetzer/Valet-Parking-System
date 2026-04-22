
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingsTable : UserControl
    {
        EditBookingWindow1 EditBookingWindow;
        InformationPanelWindow InformationPanelWindow;
        Booking SelectedBooking;
        BookingSubForm ParentForm;

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
            this.ParentForm = parent;
        }

        public void EditBooking(Booking booking)
        {
            ParentForm.EditBooking(booking);
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
                disablebuttons();
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
                        await Task.Delay(1);
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
            SelectedBooking = booking;
            BookingSelected = true;
            enablebuttons();
        }
        private void enablebuttons() 
        {
            btnEditBooking.Enabled = true;  
            BtnMarkForRetrieval.Enabled = true;
            BtnInformation.Enabled = true;
            BtnPrint.Enabled = true;
        }

        private void disablebuttons()
        {
            btnEditBooking.Enabled = false;
            BtnMarkForRetrieval.Enabled = false;
            BtnInformation.Enabled = false;
            BtnPrint.Enabled = false;
            SelectedBooking = null;
        }
        //-----------------------------Events-----------------------------
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            if (SelectedBooking != null)
            {
                EditBookingWindow?.Close();
                EditBookingWindow?.Dispose();
                EditBookingWindow = new EditBookingWindow1(this, SelectedBooking);
                EditBookingWindow.StartPosition = FormStartPosition.CenterScreen;
                EditBookingWindow.ShowDialog();
                EditBookingWindow = null;
            }
        }

        public void CancelEditBooking()
        {
            EditBookingWindow?.Close();
            EditBookingWindow?.Dispose();
            EditBookingWindow = null;
        }

        private void BtnMarkForRetrieval_Click(object sender, EventArgs e)
        {

        }
        private void BtnInformation_Click(object sender, EventArgs e)
        {
            if (SelectedBooking != null)
            {
                InformationPanelWindow = new InformationPanelWindow(this, SelectedBooking);

                InformationPanelWindow.FormBorderStyle = FormBorderStyle.None;
                InformationPanelWindow.StartPosition = FormStartPosition.Manual;
                InformationPanelWindow.StartPosition = FormStartPosition.CenterScreen;
                InformationPanelWindow.ShowInTaskbar = false;
                InformationPanelWindow.Size = new Size(1600, 900);
                InformationPanelWindow.Show(this);
            }
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
