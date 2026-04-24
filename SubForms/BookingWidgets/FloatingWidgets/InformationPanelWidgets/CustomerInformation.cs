using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class CustomerInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public CustomerInformation()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
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
    }
}