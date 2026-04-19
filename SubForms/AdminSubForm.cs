using System.Data.SqlTypes;
using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.SubForms
{
    public partial class AdminSubForm : UserControl
    {
        public AdminSubForm()
        {
            InitializeComponent();
            this.parkingSpacesTable.SetParent(this);
            this.operatorsTable.SetParent(this);
        }

        public void LoadParkingSpaces(List<ParkingSpace> parkingSpaces, List<Operator> loadedOperators)
        {
            this.parkingSpacesTable.LoadParkingSpacesAsync(parkingSpaces);
            this.operatorsTable.LoadOperatorsAsync(loadedOperators);
        }

        //-----------------------------Events-----------------------------


        //-----------------------------Database Calls-----------------------------  

        //implament database functionality

        // Space-----------------------------------------------------------
        public void OnSpaceAdd(ParkingSpace spacedata)
        {
            bool added = AdminRepository.AddSpace(spacedata);

            if (added)
                MessageBox.Show("Space created", "Success");
            else
                MessageBox.Show("Failed to create space.", "Error");
        }

        public void EditSpace(ParkingSpace spacedata)
        {
            bool edited = AdminRepository.EditSpace(spacedata);

            if (edited)
                MessageBox.Show("Space edited", "Success");
            else
                MessageBox.Show("Failed to edit space.", "Error");
        }

        public void RemoveSpace(ParkingSpace spacedata)
        {
            bool removed = AdminRepository.RemoveSpace(spacedata);

            if (removed)
                MessageBox.Show("Space removed", "Success");
            else
                MessageBox.Show("Failed to remove space.", "Error");
        }



        // Operator-----------------------------------------------------------


        internal void OnOperatorAdd(Operator operatordata)
        {
            bool added = AdminRepository.AddOperator(operatordata);

            if (added)
                MessageBox.Show("Operator created", "Success");
            else
                MessageBox.Show("Failed to create operator.", "Error");
        }

        internal void EditOperator(Operator operatordata)
        {
            bool edited = AdminRepository.EditOperator(operatordata);

            if (edited)
                MessageBox.Show("Operator edited", "Success");
            else
                MessageBox.Show("Failed to edit operator.", "Error");
        }

        internal void RemoveOperator(Operator operatordata)
        {
            bool removed = AdminRepository.RemoveOperator(operatordata);

            if (removed)
                MessageBox.Show("Operator removed", "Success");
            else
                MessageBox.Show("Failed to remove operator.", "Error");
        }
    }
}
 