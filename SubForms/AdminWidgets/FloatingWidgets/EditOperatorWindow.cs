using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

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

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 30, 30));
        }

        //-----------------------------Actions-----------------------------

        public void CloseAndDispose()
        {
            Close();
            Dispose();
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