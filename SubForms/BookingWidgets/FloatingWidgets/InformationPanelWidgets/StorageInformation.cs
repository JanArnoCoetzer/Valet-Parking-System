using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class StorageInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public StorageInformation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //-----------------------------Setup-----------------------------

        internal void SetInformation(
            string dateFrom,
            string timeFrom,
            string dateTo,
            string timeTo,
            ParkingSpace parkingSpace,
            Operator storageOperator)
        {
            if (parkingSpace == null || storageOperator == null)
            {
                return;
            }

            txtSpace.Text = parkingSpace.LotIdentifier.ToString();

            txtDatestored.Text = dateFrom;
            txtTimestored.Text = timeFrom;
            txtDatepickup.Text = dateTo;
            txtTimepickup.Text = timeTo;

            txtStorageName.Text = storageOperator.fullName;
            txtStorageTelephone.Text = storageOperator.telephone;
            txtStorageEmail.Text = storageOperator.email;
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