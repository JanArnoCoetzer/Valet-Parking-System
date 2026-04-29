using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Login;
using Valet_Parking_System.Services;

namespace Valet_Parking_System.SubForms
{
    public partial class LoginSubform : UserControl
    {
        private MainLanding _parentForm;
        private List<Operator> _loadedOperators;

        //-----------------------------Constructor-----------------------------

        public LoginSubform()
        {
            InitializeComponent();
            loginWidget.SetParent(this);
        }

        //-----------------------------Setup-----------------------------

        public void SetMainLanding(MainLanding parentForm)
        {
            _parentForm = parentForm;
        }

        internal void LoadOperators(List<Operator> loadedOperators)
        {
            _loadedOperators = loadedOperators ?? new List<Operator>();
        }

        //-----------------------------Authentication-----------------------------

        public LoginResult CheckOperatorForLogin(string name, string password)
        {        
            return LoginService.CheckLogin(_loadedOperators, name, password);
        }

        public void LogInAsOperator(string name, string password)
        {
           
            Operator foundOperator = LoginService.FindOperator(_loadedOperators, name, password);
            if (foundOperator == null)
            {
                MessageBox.Show("Operator not found.");
                return;
            }

            if (_parentForm == null)
            {
                MessageBox.Show("Main landing form is not available.");
                return;
            }

            _parentForm.LoginAsOperator(foundOperator);
        }
    }
}