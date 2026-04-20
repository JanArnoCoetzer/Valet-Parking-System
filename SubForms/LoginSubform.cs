using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms
{
    public partial class LoginSubform : UserControl
    {
        MainLanding ParentForm;
        List<Operator> LoadedOperators;

        public LoginSubform()
        {
            InitializeComponent();
            loginWidget.SetParent(this);
        }
        public void setMainLanding(MainLanding parentForm) 
        {
            ParentForm = parentForm;
        }
        internal void LoadOperators(List<Operator> loadedOperators)
        {
            LoadedOperators = loadedOperators;
        }
        public int CheckOperatorForLogin(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password))
            {
                return 1;
            }

            if (LoadedOperators == null || LoadedOperators.Count == 0)
            {
                return 2;
            }

            Operator foundOperator = LoadedOperators.Find(op =>
                op.fullName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                op.Password == password);

            if (foundOperator == null)
            {
                return 3;
            }

            return 0;
        }

        public void LogInAsOperator(string name, string password)
        {
            Operator foundOperator = LoadedOperators.Find(op =>
                op.fullName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                op.Password == password);

            if (foundOperator == null)
            {
                MessageBox.Show("Operator not found.");
                return;
            }

            ParentForm.LoginAsOperator(foundOperator);
        }
    }
}
