using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class EditOperatorWidget : UserControl
    {
        OperatorsTable ot;
        Operator OperatorDataData;
        EditOperatorWindow parentform;
        private bool removeOperatorChecked = false;
        public EditOperatorWidget()
        {
            InitializeComponent();
        }



        internal void setOperatorData(Operator operatorData)
        {
            OperatorDataData = operatorData;
            txtOperatorId.Text = operatorData.operatorID.ToString();
            txtFullName.Text = operatorData.fullName.ToString();
            txtTelephone.Text = operatorData.telephone.ToString();
            txtAddress.Text = operatorData.fulladdress.ToString();
            txtEmail.Text = operatorData.email.ToString();
            txtdatefrom.Text = operatorData.datejoined.ToString();
        }


        internal void setParentForm(EditOperatorWindow editOperatorWindow)
        {
            parentform = editOperatorWindow;
        }

        internal void setParentTable(OperatorsTable ot)
        {
            this.ot = ot;
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



        private void RemoveCheck_CheckedChanged(object sender, EventArgs e)
        {
            removeOperatorChecked = RemoveCheck.Checked;

            if (removeOperatorChecked)
            {
                BtnUpdateOperator.Text = "Remove Operator";
                ValidationErrorLabel.Text = "You will Remove an Operator";
                ValidationErrorLabel.Visible = true;
            }
            else
            {
                BtnUpdateOperator.Text = "Update Operator";
            }
        }

        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            ot.CancelEditOperator();
        }

        private void BtnUpdateorRemoveOperator_Click(object sender, EventArgs e)
        {
            if (!removeOperatorChecked)
            {
                


                ot.EditOperator();
                
            }
            else if (removeOperatorChecked) 
            {
                switch (removeOperatorValidation())
                {
                    case 0:
                        ot.RemoveOperator();
                        break;

                    case 1:
                        ValidationErrorLabel.Text = "You need to enter your ID";
                        break;

                    case 2:
                        ValidationErrorLabel.Text = "You need to confirm operator removal";
                        break;
                }

            }

           


        }

        private int removeOperatorValidation() 
        {
            int validationresault = -1;

            if (RemovingOperatorID.Text == "")
            {
                validationresault = 1;
            }

            else if (!Confirmationcheck.Checked)
            {
                validationresault = 2;
            }

            else 
            {
                validationresault = 0;
            }

            return validationresault;
        }

    }
}
