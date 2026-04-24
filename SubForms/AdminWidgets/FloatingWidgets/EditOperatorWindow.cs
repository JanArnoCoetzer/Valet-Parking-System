using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class EditOperatorWindow : Form
    {
        private EditOperatorWidget widget;

        //-----------------------------Constructor-----------------------------

        public EditOperatorWindow(OperatorsTable operatorsTable, Operator operatorData)
        {
            InitializeComponent();

            widget = editOperatorWidget;
            widget.SetParentTable(operatorsTable);
            widget.SetOperatorData(operatorData);
            widget.SetParentForm(this);

            RegionHelper.ApplyRoundedRegion(this, 30);
        }

        //-----------------------------Actions-----------------------------

        public void CloseAndDispose()
        {
            Close();
            Dispose();
        }

    }
}