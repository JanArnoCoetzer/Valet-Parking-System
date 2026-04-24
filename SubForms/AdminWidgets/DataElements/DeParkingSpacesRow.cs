using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    public partial class DeParkingSpacesRow : UserControl
    {
        private ParkingSpacesTable parentTable;
        private ParkingSpace parkingSpace;

        private bool selected = false;
        private Color panelColor;

        private Color panelLight = Color.FromArgb(245, 245, 245);
        private Color panelDark = Color.FromArgb(235, 235, 235);

        //-----------------------------Constructor-----------------------------

        public DeParkingSpacesRow(ParkingSpace parkingSpace, ParkingSpacesTable parentTable, bool backPanelDark = false)
        {
            InitializeComponent();

            this.parentTable = parentTable;
            this.parkingSpace = parkingSpace;

            txtSpaceID.Text = parkingSpace.SpaceID.ToString();
            txtLotIdentifier.Text = parkingSpace.LotIdentifier;
            txtStatus.Text = parkingSpace.Status;

            panelColor = backPanelDark ? panelDark : panelLight;
            SetColor(panelColor);
        }

        //-----------------------------Selection-----------------------------

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }

        //-----------------------------Events-----------------------------

        private void TableElement_MouseHover(object sender, EventArgs e)
        {
            if (!selected)
                SetColor(Color.FromArgb(135, 206, 235));
        }

        private void TableElement_MouseLeave(object sender, EventArgs e)
        {
            if (!selected)
                SetColor(panelColor);
        }

        private void TableElement_Clicked(object sender, MouseEventArgs e)
        {
            parentTable.DeselectAllElements();

            selected = true;
            SetColor(Color.FromArgb(70, 130, 180));

            parentTable.SelectedSpaceUpdate(parkingSpace);
        }

        //-----------------------------Rendering-----------------------------

        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }
    }
}