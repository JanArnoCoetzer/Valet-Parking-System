using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes.Constants.Login;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.LoginFormWidgets
{
    public partial class LoginWidget : UserControl
    {
        private LoginSubform _parentForm;

        //-----------------------------Constructor-----------------------------

        public LoginWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        //-----------------------------Setup-----------------------------

        public void SetParent(LoginSubform parentForm)
        {
            _parentForm = parentForm;
        }

        //-----------------------------Actions-----------------------------

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (_parentForm == null)
            {
                ValidationErrorLabel.Text = "Login form is not available.";
                ValidationErrorLabel.Visible = true;
                return;
            }

            var result = _parentForm.CheckOperatorForLogin(txtName.Text, txtpassword.Text);

            if (result == 0)
            {
                ValidationErrorLabel.Visible = false;
                _parentForm.LogInAsOperator(txtName.Text, txtpassword.Text);
            }
            else
            {
                ValidationErrorLabel.Text = GetLoginErrorMessage(result);
                ValidationErrorLabel.Visible = true;
            }
        }

        private string GetLoginErrorMessage(LoginResult result)
        {
            return result switch
            {
                LoginResult.MissingInput => "Please enter name and password.",
                LoginResult.DatabaseUnavailable => "Database error.",
                LoginResult.InvalidCredentials => "Invalid login details.",
                _ => "Unknown error."
            };
        }


    }
}