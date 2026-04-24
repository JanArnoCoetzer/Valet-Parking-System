using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class EditOperatorWidget : UserControl
    {
        private OperatorsTable parentTable;
        private Operator operatorData;
        private EditOperatorWindow parentForm;

        private bool removeOperatorChecked = false;

        //-----------------------------Constructor-----------------------------

        public EditOperatorWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Parent Setup-----------------------------

        internal void SetParentForm(EditOperatorWindow editOperatorWindow)
        {
            parentForm = editOperatorWindow;
        }

        internal void SetParentTable(OperatorsTable operatorsTable)
        {
            parentTable = operatorsTable;
        }

        internal void SetOperatorData(Operator selectedOperator)
        {
            operatorData = selectedOperator;

            txtOperatorId.Text = selectedOperator.OperatorID.ToString();
            txtFullName.Text = selectedOperator.fullName;
            txtTelephone.Text = selectedOperator.telephone;
            txtAddress.Text = selectedOperator.fulladdress;
            txtEmail.Text = selectedOperator.email;
            txtdatefrom.Text = selectedOperator.datejoined;
        }

        //-----------------------------Actions-----------------------------

        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            parentTable.CancelEditOperator();
        }

        private void BtnUpdateorRemoveOperator_Click(object sender, EventArgs e)
        {
            if (!removeOperatorChecked)
            {
                if (ValidateIdTextBox() == 0)
                {
                    Operator editedOperatorData = GetEditedData();

                    if (editedOperatorData.ValidateOperator() == 0)
                    {
                        parentTable.EditOperator(editedOperatorData);
                    }
                    else
                    {
                        ValidationErrorLabel.Text = editedOperatorData.GetValidationErrorMsg();
                        ValidationErrorLabel.Visible = true;
                    }
                }
            }
            else
            {
                switch (RemoveOperatorValidation())
                {
                    case 0:
                        parentTable.RemoveOperator(operatorData);
                        break;

                    case 1:
                        ValidationErrorLabel.Text = "You need to enter your ID";
                        ValidationErrorLabel.Visible = true;
                        break;

                    case 2:
                        ValidationErrorLabel.Text = "You need to confirm operator removal";
                        ValidationErrorLabel.Visible = true;
                        break;
                }
            }
        }

        //-----------------------------Validation-----------------------------

        private void RemoveCheck_CheckedChanged(object sender, EventArgs e)
        {
            removeOperatorChecked = RemoveCheck.Checked;

            if (removeOperatorChecked)
            {
                BtnUpdateOperator.Text = "Remove Operator";
                ValidationErrorLabel.Text = "You will remove an operator";
                ValidationErrorLabel.Visible = true;
            }
            else
            {
                BtnUpdateOperator.Text = "Update Operator";
                ValidationErrorLabel.Text = "";
                ValidationErrorLabel.Visible = false;
            }
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

        private int RemoveOperatorValidation()
        {
            if (string.IsNullOrWhiteSpace(RemovingOperatorID.Text))
                return 1;

            if (!Confirmationcheck.Checked)
                return 2;

            return 0;
        }

        //-----------------------------Helpers-----------------------------

        private Operator GetEditedData()
        {
            Operator editedOperatorData = new Operator(
                int.Parse(txtOperatorId.Text),
                "O",
                txtFullName.Text,
                txtdatefrom.Text,
                txtAddress.Text,
                txtTelephone.Text,
                txtEmail.Text
            );

            return editedOperatorData;
        }

        
    }
}