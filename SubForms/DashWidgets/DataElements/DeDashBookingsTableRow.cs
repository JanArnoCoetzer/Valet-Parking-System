using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets;

namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    public partial class DeDashBookingsTableRow : UserControl
    {
        OperatorSubForm Parent;
        Booking bookingdata;
        public bool selected = false;

        public DeDashBookingsTableRow(Booking booking, bool BackPaneldark = false)
        {
            InitializeComponent();

            bookingdata = booking;          

            txtBookingId.Text = bookingdata.BookingId.ToString();
            txtCarReg.Text = bookingdata.Vehicle.Registation.ToString();
            txtName.Text = bookingdata.Customer.FullName.ToString();
            txtParkingSpace.Text = bookingdata.ParkingSpace.LotIdentifier.ToString();

            txtTime.Text = bookingdata.DateTo.ToString();
            txtTime.Text = bookingdata.TimeTo.ToString();

            if (BackPaneldark)
            {
                panelColor = panelDark;
            }
            else
            {
                panelColor = panelLight;
            }
            SetColor(panelColor);

        }




      
        //-----------------------------ExternalCalls-----------------------------

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }
        ///-----------------------------Rendering-----------------------------
        bool BackPaneldark = false;
        Color panelColor;
        Color panelLight = Color.FromArgb(245, 245, 245);
        Color panelDark = Color.FromArgb(235, 235, 235);


        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }
    }
}
