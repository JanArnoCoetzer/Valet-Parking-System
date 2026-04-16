using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.AdminWidgets.DataElements;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using Valet_Parking_System.SubForms.DashWidgets.DataElements;

namespace Valet_Parking_System.SubForms.AdminWidgets
{
    public partial class ParkingSpacesTable : UserControl
    {
        AdminSubForm parent;
        public ParkingSpace selectedSpace;
        public ParkingSpacesTable()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
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
        internal void SetParent(AdminSubForm adminSubForm)
        {
            parent = adminSubForm;
        }

        public async Task LoadParkingSpacesAsync(List<ParkingSpace> parkingSpaces)
        {
            //chunk based table population to avoid creating error handle overflow spaces>100
            try
            {
                ParkingSpacesTableContentPanel.Controls.Clear();

                if (parkingSpaces == null || parkingSpaces.Count == 0)
                    return;

                const int chunkSize = 20;
                int totalChunks = (parkingSpaces.Count + chunkSize - 1) / chunkSize;

                for (int chunk = 0; chunk < totalChunks; chunk++)
                {
                    int start = chunk * chunkSize;
                    int end = Math.Min(start + chunkSize, parkingSpaces.Count);

                    for (int i = start; i < end; i++)
                    {
                        var parkingSpace = parkingSpaces[i];
                        bool isDarkRow = i % 2 == 0;
                        var row = new DeParkingSpacesRow(parkingSpace, this, isDarkRow);
                        ParkingSpacesTableContentPanel.Controls.Add(row);
                        Debug.WriteLine("status = " + parkingSpace.Status);
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DisplayParkingSpaces failed: {ex.Message}");
                MessageBox.Show($"Error loading ParkingSpaces: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void DeselectAllElements()
        {
            foreach (Control c in ParkingSpacesTableContentPanel.Controls)
            {
                if (c is DeParkingSpacesRow row)
                    row.Deselect();
            }
        }

        private void BtnAddSpace_Click(object sender, EventArgs e)
        {
            parent.OnSpaceAdd(selectedSpace);
        }

        private void BtnEditSpace_Click(object sender, EventArgs e)
        {
            if (selectedSpace != null) 
            {
                ParkingSpace EditedSpace = new ParkingSpace(int.Parse(txtBoxSpaceID.Text), txtboxLotIdentifier.Text, StatusBox.Text);
                parent.EditSpace(EditedSpace);
            }      
        }

        public void SelectedSpaceUpdate(ParkingSpace parking) 
        {
            selectedSpace = parking;
            if (selectedSpace != null) 
            {    
                txtBoxSpaceID.Text = selectedSpace.SpaceID.ToString();
                txtboxLotIdentifier.Text = selectedSpace.LotIdentifier;
                StatusBox.Text = selectedSpace.Status;
            }
            
        }
    }
}

