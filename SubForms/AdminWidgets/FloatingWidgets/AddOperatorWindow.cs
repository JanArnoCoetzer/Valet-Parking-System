using System.Runtime.InteropServices;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class AddOperatorWindow : Form
    {
        private AddOperatorWidget widget;

        //-----------------------------Constructor-----------------------------

        public AddOperatorWindow()
        {
        }

        public AddOperatorWindow(OperatorsTable operatorsTable)
        {
            InitializeComponent();

            widget = addOperatorWidget;
            widget.SetParentTable(operatorsTable);
            widget.SetParentForm(this);

            RegionHelper.ApplyRoundedRegion(this, 30);
        }

        //-----------------------------Actions-----------------------------

        public void CloseAndDispose()
        {
            Close();
            Dispose();
        }

        //-----------------------------Rendering-----------------------------
    }
}