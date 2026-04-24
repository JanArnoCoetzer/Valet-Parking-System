using System.Drawing;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    public partial class DeDashBookingsTableRow : UserControl
    {
        private readonly Booking _bookingData;
        private readonly Color _panelLight = Color.FromArgb(245, 245, 245);
        private readonly Color _panelDark = Color.FromArgb(235, 235, 235);
        private Color _panelColor;

        public bool Selected { get; private set; }

        //-----------------------------Constructor-----------------------------

        public DeDashBookingsTableRow(Booking booking, bool backPanelDark = false)
        {
            InitializeComponent();

            _bookingData = booking;

            txtBookingId.Text = _bookingData.BookingId.ToString();
            txtCarReg.Text = _bookingData.Vehicle.Registation;
            txtName.Text = _bookingData.Customer.FullName;
            txtParkingSpace.Text = _bookingData.ParkingSpace.LotIdentifier.ToString();

            txtTime.Text = _bookingData.TimeTo;

            _panelColor = backPanelDark ? _panelDark : _panelLight;
            SetColor(_panelColor);
        }

        //-----------------------------External Calls-----------------------------

        public void Deselect()
        {
            Selected = false;
            SetColor(_panelColor);
        }

        //-----------------------------Rendering-----------------------------

        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }
    }
}