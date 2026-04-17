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
using Valet_Parking_System.SubForms.BookingWidgets;

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class AddOperatorWindow : Form
    {
        AddOperatorWidget Widget;

        public AddOperatorWindow()
        {
            
        }

        public AddOperatorWindow(OperatorsTable ot)
        {
            InitializeComponent();

            Widget = this.addOperatorWidget;
            Widget.setParentTable(ot);
            Widget.setParentForm(this);

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 30, 30 ));
        }
        public void CloseAndDispose()
        {
            this.Close();
            this.Dispose();
        }

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
