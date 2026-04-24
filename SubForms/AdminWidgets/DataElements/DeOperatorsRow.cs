using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    public partial class DeOperatorsRow : UserControl
    {
        private Operator operatorData;
        private OperatorsTable parentTable;

        private bool selected = false;
        private Color panelColor;

        private Color panelLight = Color.FromArgb(245, 245, 245);
        private Color panelDark = Color.FromArgb(235, 235, 235);

        //-----------------------------Constructor-----------------------------

        public DeOperatorsRow(Operator operatorData, OperatorsTable parentTable, bool backPanelDark = false)
        {
            InitializeComponent();

            this.operatorData = operatorData;
            this.parentTable = parentTable;

            txtOperatorID.Text = operatorData.OperatorID.ToString();
            txtFullName.Text = operatorData.fullName;

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

        private void TableElement_Clicked(object sender, EventArgs e)
        {
            parentTable.DeselectAllElements();

            selected = true;
            SetColor(Color.FromArgb(70, 130, 180));

            parentTable.SelectedOperatorUpdate(operatorData);
        }

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

        //-----------------------------Rendering-----------------------------

        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }
    }
}