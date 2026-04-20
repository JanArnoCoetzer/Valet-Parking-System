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

namespace Valet_Parking_System.SubForms.DashWidgets.DataElements
{
    public partial class StatusHotbarWidget : UserControl
    {
        public StatusHotbarWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void setValues(string todaysbookings,string spacesavailable,string carsforretrieval) 
        {
            txtTodaysBookings.Text = todaysbookings;
            txtParkingAvailable.Text = spacesavailable;
            txtCarsFoRetrieval.Text = carsforretrieval;
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse
        );
    }
}
