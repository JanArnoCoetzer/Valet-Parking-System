using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.SubForms.OperatorWidgets.DataElements;

namespace Valet_Parking_System.SubForms.OperatorWidgets
{
    public partial class CarStorageWidget : UserControl
    {
        private OperatorSubForm Parent;
        private List<Booking> Bookings;
        private Booking SelectedBooking;

        //-----------------------------Constructor-----------------------------

        public CarStorageWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Parent Setup-----------------------------

        public void SetParent(OperatorSubForm parent)
        {
            Parent = parent;
        }

        //-----------------------------Data Loading-----------------------------

        public void LoadBookings(List<Booking> bookings)
        {
            Bookings = bookings;
            LoadCarsToStoreAsync(bookings);
        }

        internal async Task LoadCarsToStoreAsync(List<Booking> bookings)
        {
            DisableButton();

            try
            {
                CarStorageTableContentPanel.Controls.Clear();

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

                        var row = new DECarStorageTableRow(booking, this, isDarkRow);
                        CarStorageTableContentPanel.Controls.Add(row);
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadCarsToStoreAsync failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-----------------------------Selection-----------------------------

        public void SelectedElement(Booking selectedBooking)
        {
            SelectedBooking = selectedBooking;

            if (SelectedBooking != null)
            {
                BtnCarStored.Enabled = true;
            }
        }

        public void DeselectAllElements()
        {
            DisableButton();

            foreach (Control c in CarStorageTableContentPanel.Controls)
            {
                if (c is DECarStorageTableRow row)
                    row.Deselect();
            }
        }

        //-----------------------------Actions-----------------------------

        private void DisableButton()
        {
            BtnCarStored.Enabled = false;
        }

        private void BtnCarStored_Click(object sender, EventArgs e)
        {
            if (SelectedBooking != null)
            {
                Parent.SetStatusStored(SelectedBooking);
            }
        }
    }
}