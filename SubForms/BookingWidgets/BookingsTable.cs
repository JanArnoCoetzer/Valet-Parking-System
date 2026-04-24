using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingsTable : UserControl
    {
        private EditBookingWindow1 editBookingWindow;
        private InformationPanelWindow informationPanelWindow;
        private Booking selectedBooking;
        private BookingSubForm parentForm;

        private FlowLayoutPanel TableContentPanel => BookingsTableContentPanel;

        //-----------------------------Constructor-----------------------------

        public BookingsTable(List<Booking> bookings)
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);        }

        public BookingsTable() : this(null)
        {
        }

        //-----------------------------Parent Setup-----------------------------

        public void SetParentForm(BookingSubForm parent)
        {
            parentForm = parent;
        }

        //-----------------------------External Calls-----------------------------

        public void EditBooking(Booking booking)
        {
            parentForm.EditBooking(booking);
        }

        public async Task DisplayBookingsAsync(List<Booking> bookings)
        {
            try
            {
                TableContentPanel.Controls.Clear();
                DisableButtons();

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
                        await Task.Delay(1);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DisplayBookingsAsync failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeselectAllElements()
        {
            foreach (Control c in TableContentPanel.Controls)
            {
                if (c is DeBookingTableRow row)
                    row.Deselect();
            }
        }

        public void SelectElement(Booking booking)
        {
            selectedBooking = booking;
            EnableButtons();
        }

        //-----------------------------Buttons-----------------------------

        private void EnableButtons()
        {
            btnEditBooking.Enabled = true;
            BtnMarkForRetrieval.Enabled = true;
            BtnInformation.Enabled = true;
            BtnPrint.Enabled = true;
        }

        private void DisableButtons()
        {
            btnEditBooking.Enabled = false;
            BtnMarkForRetrieval.Enabled = false;
            BtnInformation.Enabled = false;
            BtnPrint.Enabled = false;
            selectedBooking = null;
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
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            if (selectedBooking != null)
            {
                informationPanelWindow = new InformationPanelWindow(this, selectedBooking);
                informationPanelWindow.FormBorderStyle = FormBorderStyle.None;
                informationPanelWindow.StartPosition = FormStartPosition.CenterScreen;
                informationPanelWindow.ShowInTaskbar = false;
                informationPanelWindow.Size = new Size(1600, 900);
                informationPanelWindow.Show(this);
            }
        }
    }
}