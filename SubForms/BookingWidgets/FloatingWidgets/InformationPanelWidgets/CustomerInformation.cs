using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class CustomerInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public CustomerInformation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //-----------------------------Setup-----------------------------

        internal void SetInformation(Customer customer)
        {
            if (customer == null)
            {
                return;
            }

            txtFullName.Text = customer.FullName;
            txtAdress.Text = customer.Address;
            txtTelephone.Text = customer.Telephone;
        }

        //-----------------------------Rendering-----------------------------

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