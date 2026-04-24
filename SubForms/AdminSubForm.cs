using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.SubForms
{
    public partial class AdminSubForm : UserControl
    {
        public Operator UsingOperator;
        public MainLanding MainLanding;
        //-----------------------------Constructor-----------------------------

        public AdminSubForm()
        {
            InitializeComponent();

            parkingSpacesTable.SetParent(this);
            operatorsTable.SetParent(this);
        }

        //-----------------------------Data Loading-----------------------------

        public void SetMainLanding(MainLanding mainLanding)
        {
            MainLanding = mainLanding;
        }
        public void LoadParkingSpaces(List<ParkingSpace> parkingSpaces, List<Operator> loadedOperators)
        {
            parkingSpacesTable.LoadParkingSpacesAsync(parkingSpaces);
            operatorsTable.LoadOperatorsAsync(loadedOperators);
        }

        //-----------------------------Space Actions-----------------------------

        public void OnSpaceAdd(ParkingSpace spaceData)
        {
            bool addedToDb = AdminRepository.AddSpace(spaceData);

            if (addedToDb)
            {
                MainLanding.LoadTables();
                MessageBox.Show("Space created", "Success");
            }
            else
            {
                MessageBox.Show("Failed to create space.", "Error");
            }
        }

        public void EditSpace(ParkingSpace spaceData)
        {
            bool editedInDb = AdminRepository.EditSpace(spaceData);

            if (editedInDb)
            {
                MainLanding.LoadTables();
                MessageBox.Show("Space edited", "Success");
            }
            else
            {
                MessageBox.Show("Failed to edit space.", "Error");
            }
        }

        public void RemoveSpace(ParkingSpace spaceData)
        {
            bool removedFromDb = AdminRepository.RemoveSpace(spaceData);

            if (removedFromDb)
            {
                MainLanding.LoadTables();
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
            bool addedToDb = AdminRepository.AddOperator(operatorData);

            if (addedToDb)
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
            bool editedInDb = AdminRepository.EditOperator(operatorData);

            if (editedInDb)
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
            bool removedFromDb = AdminRepository.RemoveOperator(operatorData);

            if (removedFromDb)
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