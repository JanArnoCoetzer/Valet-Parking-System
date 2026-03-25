using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;

namespace Valet_Parking_System.SubForms.RetrievalWidgets
{
    public partial class RetrievalTable : UserControl
    {
        public RetrievalTable()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        public async void DisplayQueueItems(List<RetrievalQueueItem> Items)
        {
            Debug.WriteLine(Items.Count);
            //chunk based table population to avoid creating error handle overflow
            try
            {
                RetrievalQueueContentPanel.Controls.Clear();

                if (Items == null || Items.Count == 0)
                    return;

                const int chunkSize = 20;
                int totalChunks = (Items.Count + chunkSize - 1) / chunkSize;

                for (int chunk = 0; chunk < totalChunks; chunk++)
                {
                    int start = chunk * chunkSize;
                    int end = Math.Min(start + chunkSize, Items.Count);

                    for (int i = start; i < end; i++)
                    {
                        var item = Items[i];
                        bool isDarkRow = i % 2 == 0;
                        var row = new DeRetrievalQueueTableRow(item);
                        RetrievalQueueContentPanel.Controls.Add(row);

                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DisplayBookings failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}

