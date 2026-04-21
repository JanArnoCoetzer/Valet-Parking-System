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

namespace Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets
{
    public partial class AddOperatorWidget : UserControl
    {
        OperatorsTable ot;
        AddOperatorWindow parentform;
        private bool removeOperatorChecked = false;
        public AddOperatorWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }


        internal void setParentForm(AddOperatorWindow editOperatorWindow)
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



        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            ot.CancelAddOperator();
        }

        private void BtnAddeOperator_Click(object sender, EventArgs e)
        {

                if (ValidateIDtxtBox() == 0)
                {
                    Operator EditedOperatorDataData = GetEditedData();

                    if (EditedOperatorDataData.ValidateOperator() == 0)
                    {
                        ot.AddOperator(EditedOperatorDataData);
                    }

                    else
                    {
                        ValidationErrorLabel.Text = EditedOperatorDataData.GetValidationErrorMsg();
                        ValidationErrorLabel.Visible = true;
                    }
                }
        }

        private Operator GetEditedData()
        {
            Operator EditedOperatorDataData = new Operator(
            int.Parse(txtOperatorId.Text),
                "O",
                txtFullName.Text,
                txtdatefrom.Text,
                txtAddress.Text,
                txtTelephone.Text,
                txtEmail.Text
            );

            return EditedOperatorDataData;
        }

        private int ValidateIDtxtBox()
        {
            int returncode = -1;

            ValidationErrorLabel.Text = "";
            ValidationErrorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(txtOperatorId.Text))
            {
                returncode = 1;
                ValidationErrorLabel.Text = "Operator requires an ID";
                ValidationErrorLabel.Visible = true;
            }
            else
            {
                returncode = 0;
            }

            return returncode;
        }
    }
}
