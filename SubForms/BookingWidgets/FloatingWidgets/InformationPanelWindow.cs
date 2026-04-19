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

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets
{
    public partial class InformationPanelWindow : Form
    {
        private BookingsTable bookingsTable;
        private Booking selectedBooking;

        public InformationPanelWindow(BookingsTable bookingsTable, Booking selectedBooking)
        {
            InitializeComponent();
            this.bookingsTable = bookingsTable;
            this.selectedBooking = selectedBooking;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        private void btnCloseInformationPanel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
