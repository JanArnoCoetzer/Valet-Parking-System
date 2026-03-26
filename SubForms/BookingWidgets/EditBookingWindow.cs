using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class EditBookingWindow : Form
    {       
        EditBookingWidget Widget;

        public EditBookingWindow(BookingsTable bt,Booking bookingdata)
        {
            InitializeComponent();

            Widget = this.EditBookingWidget;
            Widget.setParentTable(bt);
            Widget.setBookingData(bookingdata);
            this.EditBookingWidget.setParentForm(this);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 30, 30
                ));
        }

        public void CloseAndDispose() 
        {
            this.Close();
            this.Dispose();
        }
        

        public BookingsTable BookingsTable { get; }
        public Booking SelectedBooking { get; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

    }
}
