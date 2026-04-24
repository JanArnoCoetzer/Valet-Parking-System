using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.AdminWidgets.DataElements;

namespace Valet_Parking_System.SubForms.AdminWidgets
{
    public partial class ParkingSpacesTable : UserControl
    {
        private AdminSubForm parent;
        public ParkingSpace selectedSpace;

        //-----------------------------Constructor-----------------------------

        public ParkingSpacesTable()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        //-----------------------------Parent Setup-----------------------------

        internal void SetParent(AdminSubForm adminSubForm)
        {
            parent = adminSubForm;
        }

        //-----------------------------Data Loading-----------------------------

        public async Task LoadParkingSpacesAsync(List<ParkingSpace> parkingSpaces)
        {
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
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadParkingSpacesAsync failed: {ex.Message}");
                MessageBox.Show($"Error loading parking spaces: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-----------------------------Selection-----------------------------

        public void DeselectAllElements()
        {
            foreach (Control c in ParkingSpacesTableContentPanel.Controls)
            {
                if (c is DeParkingSpacesRow row)
                    row.Deselect();
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

        //-----------------------------Actions-----------------------------

        private void BtnAddSpace_Click(object sender, EventArgs e)
        {
            if (selectedSpace != null)
            {
                parent.OnSpaceAdd(selectedSpace);
            }
        }

        private void BtnEditSpace_Click(object sender, EventArgs e)
        {
            if (selectedSpace != null)
            {
                ParkingSpace editedSpace = new ParkingSpace(
                    int.Parse(txtBoxSpaceID.Text),
                    txtboxLotIdentifier.Text,
                    StatusBox.Text
                );

                parent.EditSpace(editedSpace);
            }
        }

        //-----------------------------Rendering-----------------------------

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
    }
}