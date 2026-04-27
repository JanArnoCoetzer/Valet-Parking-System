using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class StorageInformation : UserControl
    {
        //-----------------------------Constructor-----------------------------

        public StorageInformation()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Setup-----------------------------

        internal void SetInformation(
            string dateFrom,
            string timeFrom,
            string dateTo,
            string timeTo,
            string parkingSpace,
            Operator storageOperator)
        {
            txtSpace.Text = string.IsNullOrWhiteSpace(parkingSpace) ? "N/A" : parkingSpace;

            txtDatestored.Text = string.IsNullOrWhiteSpace(dateFrom) ? "N/A" : dateFrom;
            txtTimestored.Text = string.IsNullOrWhiteSpace(timeFrom) ? "N/A" : timeFrom;
            txtDatepickup.Text = string.IsNullOrWhiteSpace(dateTo) ? "N/A" : dateTo;
            txtTimepickup.Text = string.IsNullOrWhiteSpace(timeTo) ? "N/A" : timeTo;

            txtStorageName.Text = storageOperator?.fullName ?? "N/A";
            txtStorageTelephone.Text = storageOperator?.telephone ?? "N/A";
            txtStorageEmail.Text = storageOperator?.email ?? "N/A";
        }


    }
}