using System.Runtime.InteropServices;

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