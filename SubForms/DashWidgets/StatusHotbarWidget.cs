using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    public partial class StatusHotbarWidget : UserControl
    {
        public StatusHotbarWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void setValues(List<Booking> bookings, List<ParkingSpace> parking)
        {
            if (bookings == null)
                bookings = new List<Booking>();

            if (parking == null)
                parking = new List<ParkingSpace>();

            txtStored.Text = bookings.Count(b => b.Status == "Stored").ToString();
            txtAwaitingStorage.Text = bookings.Count(b => b.Status == "AwaitingStorage").ToString();
            txtAwaitingPickUp.Text = bookings.Count(b => b.Status == "AwaitingPickUp").ToString();
            txtAwaitingOwner.Text = bookings.Count(b => b.Status == "AwaitingOwner").ToString();

            txtUpcomingBookings.Text = bookings.Count(b =>
                DateTime.ParseExact(
                    b.DateFrom,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture
                ).Date == DateTime.Today
            ).ToString();

            txtAvailableParking.Text = parking.Count(p => p.Available).ToString();
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
