using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.SubForms
{
    public partial class AdminSubForm : UserControl
    {

        public Operator UsingOperator;

        //-----------------------------Constructor-----------------------------

        public AdminSubForm()
        {
            InitializeComponent();

            parkingSpacesTable.SetParent(this);
            operatorsTable.SetParent(this);
        }

        //-----------------------------Data Loading-----------------------------

        public void LoadParkingSpaces(List<ParkingSpace> parkingSpaces, List<Operator> loadedOperators)
        {
            parkingSpacesTable.LoadParkingSpacesAsync(parkingSpaces);
            operatorsTable.LoadOperatorsAsync(loadedOperators);
        }

        //-----------------------------Space Actions-----------------------------

        public void OnSpaceAdd(ParkingSpace spaceData)
        {
            bool added = AdminRepository.AddSpace(spaceData);

            if (added)
            {
                MessageBox.Show("Space created", "Success");
            }
            else
            {
                MessageBox.Show("Failed to create space.", "Error");
            }
        }

        public void EditSpace(ParkingSpace spaceData)
        {
            bool edited = AdminRepository.EditSpace(spaceData);

            if (edited)
            {
                MessageBox.Show("Space edited", "Success");
            }
            else
            {
                MessageBox.Show("Failed to edit space.", "Error");
            }
        }

        public void RemoveSpace(ParkingSpace spaceData)
        {
            bool removed = AdminRepository.RemoveSpace(spaceData);

            if (removed)
            {
                MessageBox.Show("Space removed", "Success");
            }
            else
            {
                MessageBox.Show("Failed to remove space.", "Error");
            }
        }

        //-----------------------------Operator Actions-----------------------------

        internal void OnOperatorAdd(Operator operatorData)
        {
            bool added = AdminRepository.AddOperator(operatorData);

            if (added)
            {
                MessageBox.Show("Operator created", "Success");
            }
            else
            {
                MessageBox.Show("Failed to create operator.", "Error");
            }
        }

        internal void EditOperator(Operator operatorData)
        {
            bool edited = AdminRepository.EditOperator(operatorData);

            if (edited)
            {
                MessageBox.Show("Operator edited", "Success");
            }
            else
            {
                MessageBox.Show("Failed to edit operator.", "Error");
            }
        }

        internal void RemoveOperator(Operator operatorData)
        {
            bool removed = AdminRepository.RemoveOperator(operatorData);

            if (removed)
            {
                MessageBox.Show("Operator removed", "Success");
            }
            else
            {
                MessageBox.Show("Failed to remove operator.", "Error");
            }
        }
    }
}