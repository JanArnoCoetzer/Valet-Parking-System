using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class CarInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public CarInformation()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Setup-----------------------------

        public void SetInformation(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return;
            }

            txtRegistration.Text = vehicle.Registation;
            txtModel.Text = vehicle.Model;
            txtColor.Text = vehicle.Color;
            txtStatus.Text = vehicle.Status;
        }

        //-----------------------------Rendering-----------------------------

       
    }
}