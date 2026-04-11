using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms
{
    public partial class AdminSubForm : UserControl
    {
        public AdminSubForm()
        {
            InitializeComponent();
            this.parkingSpacesTable.SetParent(this);
        }

        public void LoadParkingSpaces(List<ParkingSpace> parkingSpaces) 
        {
            this.parkingSpacesTable.LoadParkingSpacesAsync(parkingSpaces);
        }

        //-----------------------------Events-----------------------------
       

        //-----------------------------Database Calls-----------------------------  

        //implament database functionality

        public void OnSpaceAdd(ParkingSpace space) 
        {
            // adds a parking space to the database
            if (true)
                MessageBox.Show("SpaceCreated", "Success");
            else
                MessageBox.Show("Failed to Create Space.", "Error");
        }
        public void EditSpace(ParkingSpace space) 
        {
            //Edits a parking space in the database
            if (true)
                MessageBox.Show("Space Edited", "Success");
            else
                MessageBox.Show("Failed to Edit Space.", "Error");
        }
    }
}
