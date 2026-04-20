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

namespace Valet_Parking_System.SubForms.LoginFormWidgets
{
    public partial class LoginWidget : UserControl
    {
        LoginSubform ParentForm;
        public LoginWidget()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }
        public void SetParent(LoginSubform parentForm) 
        {
            ParentForm = parentForm;
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int result = ParentForm.CheckOperatorForLogin(txtName.Text, txtpassword.Text);

            if (result == 0)
            {
                ParentForm.LogInAsOperator(txtName.Text, txtpassword.Text);
            }
            else
            {
                ValidationErrorLabel.Text = GetLoginErrorMessage(result);
                ValidationErrorLabel.Visible = true;
            }
        }
        private string GetLoginErrorMessage(int result)
        {
            return result switch
            {
                1 => "Please enter name and password.",
                2 => "Database error.",
                3 => "Invalid login details.",
                _ => "Unknown error."
            };
        }

    }
}
