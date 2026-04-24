using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    public partial class CarSelection_Widget : UserControl
    {
        private OperatorSubForm Parent;
        private List<Booking> Bookings;
        private Booking SelectedBooking;

        //-----------------------------Constructor-----------------------------

        public CarSelection_Widget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                CarAwaitingOwnerTableContentPanel.Controls.Clear();

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

                        var row = new DEAwaitingOwnerTableRow(booking, this, isDarkRow);
                        CarAwaitingOwnerTableContentPanel.Controls.Add(row);
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

        public void SelectBooking(Booking selectedBooking)
        {
            SelectedBooking = selectedBooking;

            if (SelectedBooking != null)
            {
                BtnHandOver.Enabled = true;
            }
        }

        public void DeselectBooking()
        {
            SelectedBooking = null;
            BtnHandOver.Enabled = false;
        }

        public void DeselectAllElements()
        {
            DeselectBooking();

            foreach (Control c in CarAwaitingOwnerTableContentPanel.Controls)
            {
                if (c is DEAwaitingOwnerTableRow row)
                {
                    row.Deselect();
                }
            }
        }

        //-----------------------------Actions-----------------------------

        private void DisableButton()
        {
            BtnHandOver.Enabled = false;
        }

        private void BtnHandOver_Click(object sender, EventArgs e)
        {
            if (SelectedBooking != null)
            {
                Parent.SetStatusHandedToOwner(SelectedBooking);
            }
        }

        //-----------------------------Rendering-----------------------------

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );
    }
}