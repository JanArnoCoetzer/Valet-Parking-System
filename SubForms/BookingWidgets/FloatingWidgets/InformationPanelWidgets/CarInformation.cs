using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class CarInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public CarInformation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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