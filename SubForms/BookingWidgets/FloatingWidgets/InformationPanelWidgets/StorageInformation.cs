using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets.FloatingWidgets.InformationPanelWidgets
{
    public partial class StorageInformation : UserControl
    {
        public StorageInformation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );

        internal void setInformation(string dateFrom,string timeFrom, string dateTo,string timeTo,ParkingSpace parkingSpace, Operator storageOperator)
        {
            txtSpace.Text = parkingSpace.LotIdentifier.ToString();

            txtDatestored.Text = dateFrom.ToString();
            txtTimestored.Text = timeFrom.ToString();
            txtDatepickup.Text = dateTo.ToString();
            txtTimepickup.Text = timeTo.ToString();

            txtStorageName.Text = storageOperator.fullName.ToString();
            txtStorageTelephone.Text = storageOperator.telephone.ToString();
            txtStorageEmail.Text = storageOperator.email.ToString();
        }
    }
}
