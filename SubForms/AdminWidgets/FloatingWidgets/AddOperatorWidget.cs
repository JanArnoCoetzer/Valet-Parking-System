using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class AddOperatorWidget : UserControl
    {
        private OperatorsTable parentTable;
        private AddOperatorWindow parentForm;

        //-----------------------------Constructor-----------------------------

        public AddOperatorWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Parent Setup-----------------------------

        internal void SetParentForm(AddOperatorWindow addOperatorWindow)
        {
            parentForm = addOperatorWindow;
        }

        internal void SetParentTable(OperatorsTable operatorsTable)
        {
            parentTable = operatorsTable;
        }

        //-----------------------------Actions-----------------------------

        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            parentTable.CancelAddOperator();
        }

        private void BtnAddeOperator_Click(object sender, EventArgs e)
        {
            if (ValidateIdTextBox() == 0)
            {
                Operator operatorData = GetOperatorData();

                if (operatorData.ValidateOperator() == 0)
                {
                    parentTable.AddOperator(operatorData);
                }
                else
                {
                    ValidationErrorLabel.Text = operatorData.GetValidationErrorMsg();
                    ValidationErrorLabel.Visible = true;
                }
            }
        }

        //-----------------------------Helpers-----------------------------

        private Operator GetOperatorData()
        {
            Operator operatorData = new Operator(
                int.Parse(txtOperatorId.Text),
                "O",
                txtFullName.Text,
                txtdatefrom.Text,
                txtAddress.Text,
                txtTelephone.Text,
                txtEmail.Text
            );

            return operatorData;
        }

        private int ValidateIdTextBox()
        {
            ValidationErrorLabel.Text = "";
            ValidationErrorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(txtOperatorId.Text))
            {
                ValidationErrorLabel.Text = "Operator requires an ID";
                ValidationErrorLabel.Visible = true;
                return 1;
            }

            return 0;
        }

      
    }
}