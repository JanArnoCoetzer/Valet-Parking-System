using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    public partial class DECarStorageTableRow : UserControl
    {
        private Booking bookingData;
        private CarStorageWidget Parent;

        private bool selected = false;
        private Color panelColor;

        private Color panelLight = Color.FromArgb(245, 245, 245);
        private Color panelDark = Color.FromArgb(235, 235, 235);

        //-----------------------------Constructor-----------------------------

        public DECarStorageTableRow(Booking booking, CarStorageWidget parent, bool backPanelDark = false)
        {
            InitializeComponent();

            bookingData = booking;
            Parent = parent;
            panelColor = backPanelDark ? panelDark : panelLight;

            SetColor(panelColor);

            txtCarRegistration.Text = booking.Vehicle.Registation;
            txtCarDiscription.Text = MakeCarDescription(booking.Vehicle);
            txtFromArea.Text = "Front Desk";
            txtToArea.Text = booking.ParkingSpace.LotIdentifier;
        }

        //-----------------------------Helpers-----------------------------

        private string MakeCarDescription(Vehicle vehicle)
        {
            if (vehicle == null)
                return "";

            return $"{vehicle.Color} {vehicle.Model}";
        }

        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }

        //-----------------------------Selection-----------------------------

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }

        //-----------------------------Events-----------------------------

        private void TableElement_MouseHover(object sender, EventArgs e)
        {
            if (!selected)
                SetColor(Color.FromArgb(135, 206, 235));
        }

        private void TableElement_MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
                SetColor(panelColor);
        }

        private void TableElement_Clicked(object sender, EventArgs e)
        {
            Parent.DeselectAllElements();

            selected = true;
            SetColor(Color.FromArgb(70, 130, 180));

            Parent.SelectedElement(bookingData);
        }
    }
}