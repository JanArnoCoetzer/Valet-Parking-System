using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;

namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    public partial class CarSelection_Widget : UserControl
    {
        OperatorSubForm Parent;
        List<Booking> Bookings;
        public CarSelection_Widget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void SetParent(OperatorSubForm parent)
        {
            Parent = parent;
        }

        public void LoadBookings(List<Booking> bookings)
        {
            Bookings = bookings;
            LoadCarsToStoreAsync(bookings);
        }

        Booking SelectedBooking;
        public void SelectBooking(Booking selectedBookin)
        {
            SelectedBooking = selectedBookin;
        }



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, int nTopRect,
           int nRightRect, int nBottomRect,
           int nWidthEllipse, int nHeightEllipse
       );

        public void DeselectAllElements()
        {
            foreach (Control c in CarAwaitingOwnerTableContentPanel.Controls)
            {
                if (c is DEAwaitingOwnerTableRow row)
                    row.Deselect();
            }
        }

        internal async Task LoadCarsToStoreAsync(List<Booking> bookings)
        {
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
                Debug.WriteLine($"DisplayOperators failed: {ex.Message}");
                MessageBox.Show($"Error loading Operators: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnHandOver_Click(object sender, EventArgs e)
        {
            if (SelectBooking != null)
            {
                Parent.SetStatusHandedToOwner(SelectedBooking);
            }
        }
    }
}
