using Valet_Parking_System.Classes;

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
        public void OnSpaceAdd(ParkingSpace spacedata) 
        {
            // adds a parking space to the database
            if (true)
                MessageBox.Show("SpaceCreated", "Success");
            else
                MessageBox.Show("Failed to Create Space.", "Error");
        }
        public void EditSpace(ParkingSpace spacedata) 
        {
            //Edits a parking space in the database
            if (true)
                MessageBox.Show("Space Edited", "Success");
            else
                MessageBox.Show("Failed to Edit Space.", "Error");
        }


        internal void OnOperatorAdd(Operator operatordata)
        {
            // adds a Operator space to the database
            if (true)
                MessageBox.Show("OperatorCreated", "Success");
            else
                MessageBox.Show("Failed to Create Operator.", "Error");
        }
        internal void EditOperator(Operator operatordata)
        {
            //Edits an Operator space in the database
            if (true)
                MessageBox.Show("Operator Edited", "Success");
            else
                MessageBox.Show("Failed to Edit Operator.", "Error");
        }
    }
}
 