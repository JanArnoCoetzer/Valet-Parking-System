using Valet_Parking_System.Classes;

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

        public int CheckOperatorForLogin(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                return 1;
            }

            if (_loadedOperators == null || _loadedOperators.Count == 0)
            {
                return 2;
            }

            Operator foundOperator = FindOperator(name, password);

            if (foundOperator == null)
            {
                return 3;
            }

            return 0;
        }

        public void LogInAsOperator(string name, string password)
        {
            Operator foundOperator = FindOperator(name, password);

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

        private Operator FindOperator(string name, string password)
        {
            if (_loadedOperators == null || _loadedOperators.Count == 0)
            {
                return null;
            }

            return _loadedOperators.Find(op =>
                op.fullName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                op.Password == password);
        }
    }
}