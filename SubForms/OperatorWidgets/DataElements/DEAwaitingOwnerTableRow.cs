
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.OperatorWidgets.DataElements
{
    public partial class DEAwaitingOwnerTableRow : UserControl
    {
        public bool selected = false;
        Booking Booking;
        CarSelection_Widget Parent;
        private readonly bool backPaneldark;

        public DEAwaitingOwnerTableRow(Booking booking,CarSelection_Widget parent  , bool BackPaneldark = false)
        {
            InitializeComponent();
            Booking = booking;
            Parent = parent;
            backPaneldark = BackPaneldark;
            if (BackPaneldark)
            {
                panelColor = panelDark;
            }
            else
            {
                panelColor = panelLight;
            }
            SetColor(panelColor);

            txtCarRegistration.Text = booking.Vehicle.Registation;
            txtCarDiscription.Text = MakeCarDescription(booking.Vehicle);
            txtOwnerFullname.Text = booking.Customer.FullName;
            txtNumber.Text = booking.Customer.Telephone;

        }

        private string MakeCarDescription(Vehicle vehicle)
        {
            if (vehicle == null)
                return "";

            return $"{vehicle.Color} {vehicle.Model}";
        }

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }

        //-----------------------------Events-----------------------------

        private void TableElement_MouseHover(object sender, EventArgs e)
        {
            if (!selected) SetColor(Color.FromArgb(135, 206, 235));
        }

        private void TableElement_MouseLeave(object sender, EventArgs e)
        {
            if (!selected) SetColor(panelColor);
        }
        private void TableElement_Clicked(object sender, EventArgs e)
        {
            Parent.DeselectAllElements();
            selected = !selected;
            SetColor(selected ? Color.FromArgb(70, 130, 180) : panelColor);
            //bookingstable.selectedElement(bookingdata);
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
