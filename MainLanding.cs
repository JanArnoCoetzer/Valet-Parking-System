using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Valet_Parking_System
{
    public partial class MainLanding : Form
    {
        //Subforms
        Panel Content;
        private DashBoardSubForm DashBoardUC = new();
        private BookingSubForm BookingsUC = new();
        private AdminSubForm AdminUC = new();
        private RetrievalQueueSubForm RetrievalQueueUC = new();
        private List<UserControl> subViews = new List<UserControl>();
        private Dictionary<System.Windows.Forms.Button, Panel> buttonPanels;
        private Panel activePanel;
   


        //DB loading
        public List<Booking> LoadedBookings;
        public List<RetrievalQueueItem> LoadedQueueItems; 
        public List<ParkingSpace> LoadedParkingSpaces;
        public List<Operator> LoadedOperators;

        //vars for testing
        private static readonly Random rand = new Random();

        public MainLanding()
        {
            InitializeComponent();
            BookingsUC.setMainLanding(this);
            LoadedParkingSpaces = CreateTestParking();
            LoadedBookings = CreateTestBookings(LoadedParkingSpaces ?? new List<ParkingSpace>(),100);
            LoadedOperators = CreateTestOperators(16);
            

            BookingsUC.LoadBookings(LoadedBookings);
            AdminUC.LoadParkingSpaces(LoadedParkingSpaces, LoadedOperators);
            LoadedQueueItems = new List<RetrievalQueueItem>();
             

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
            Content = this.ContentPanel;

            // Initialize subviews
            subViews.Add(DashBoardUC);
            subViews.Add(BookingsUC);
            subViews.Add(AdminUC);
            subViews.Add(RetrievalQueueUC);

            foreach (var view in subViews)
            {
                view.Dock = DockStyle.Fill;
            }


            // Initialize buttonPanels
            buttonPanels = new Dictionary<System.Windows.Forms.Button, Panel>
            {
                { DashBoardButton, DashHoverPanel },
                { BookingsButton, BookingsHoverPanel },
                { RetrievalQueueButton, RetrievalQueueHoverPanel },
                { AdminButton, AdminHoverPanel }
            };

            SetContent(DashBoardUC, Content);

            DashBoardUC.Updatenearistbookings(LoadedBookings);


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

        private void SetContent(UserControl uc, Panel ContentPnl)
        {
            foreach (var view in subViews)
                view.Hide();

            ContentPnl.Controls.Clear();
            ContentPnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }


        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
            {

                foreach (var p in buttonPanels.Values)
                    p.BackColor = Color.FromArgb(254, 254, 254);

                panel.BackColor = Color.FromArgb(8, 108, 236);
                activePanel = panel;


                switch (btn.Name)
                {
                    case "DashBoardButton":
                        SetContent(DashBoardUC, Content);
                        break;
                    case "BookingsButton":
                        SetContent(BookingsUC, Content);
                        break;
                    case "AdminButton":
                        SetContent(AdminUC, Content);
                        break;
                    case "RetrievalQueueButton":
                        SetContent(RetrievalQueueUC, Content);
                        break;
                }
            }
        }


        private void NavigationButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
            {
                if (panel != activePanel)
                {
                    panel.BackColor = Color.FromArgb(8, 108, 236);
                }
            }
        }

        private void NavigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
            {
                if (panel != activePanel)
                {
                    panel.BackColor = Color.FromArgb(254, 254, 254);
                }
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }




        //-----------------------------Testing Fuctions-----------------------------
        private List<Booking> CreateTestBookings(List<ParkingSpace> parkingSpaces, int amount = 25)
        {
            var bookings = new List<Booking>();
            var random = new Random();

            string[] firstNames = { "John", "Jane", "Bob", "Alice", "Mike", "Sarah", "Tom", "Emma", "David", "Lisa" };
            string[] lastNames = { "Doe", "Smith", "Wilson", "Brown", "Taylor", "Davis", "Clark", "Lewis", "Walker", "Hall" };
            string[] models = { "Toyota Corolla", "Ford Focus", "VW Golf", "Honda Civic", "BMW 3 Series", "Mercedes C-Class", "Audi A4", "Skoda Octavia", "Hyundai i30", "Kia Sportage" };
            string[] colors = { "Blue", "Red", "Black", "White", "Grey", "Silver", "Green", "Yellow", "Purple", "Orange" };
            string[] phonePrefixes = { "087", "086", "085", "083", "089" };

            DateTime today = DateTime.Today;
            string todayStr = today.ToString("dd/MM/yyyy");

            var availableSpaces = new List<ParkingSpace>();
            if (parkingSpaces != null && parkingSpaces.Any())
            {
                availableSpaces = parkingSpaces
                    .Where(ps => ps.Available)
                    .OrderBy(ps => ps.SpaceID)
                    .ToList();

                if (!availableSpaces.Any())
                    availableSpaces = parkingSpaces
                        .OrderBy(ps => ps.SpaceID)
                        .ToList();
            }

            int firstBatch = Math.Min(20, amount);

            for (int i = 0; i < firstBatch; i++)
            {
                ParkingSpace? space = availableSpaces.FirstOrDefault();

                if (space != null)
                {
                    space.setStatus("Occupied");
                    availableSpaces.Remove(space);
                }

                var testBooking = new Booking
                {
                    BookingId = i + 1,
                    parkingspace = space,
                    CarReg = GenerateIrishPlate(random),
                    FullName = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}",
                    DateFrom = todayStr,
                    DateTo = todayStr,
                    TimeFrom = $"{random.Next(8, 18):D2}:{random.Next(0, 60):D2}",
                    TimeTo = $"{random.Next(16, 22):D2}:{random.Next(0, 60):D2}",
                    CarModel = models[random.Next(models.Length)],
                    CarColor = colors[random.Next(colors.Length)],
                    TelephoneNum = $"{phonePrefixes[random.Next(phonePrefixes.Length)]}{random.Next(1000000, 9999999)}",
                    Address = $"123{random.Next(1, 999)} Test St, Dublin {random.Next(1, 25)}"
                };

                bookings.Add(testBooking);
            }

            int remaining = amount - firstBatch;

            for (int i = 0; i < remaining; i++)
            {
                ParkingSpace? space = availableSpaces.FirstOrDefault();

                if (space != null)
                {
                    space.setStatus("Occupied");
                    availableSpaces.Remove(space);
                }

                var testBooking = new Booking
                {
                    BookingId = i + firstBatch + 1,
                    parkingspace = space,
                    CarReg = GenerateIrishPlate(random),
                    FullName = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}",
                    DateFrom = DateTime.Now.AddDays(-random.Next(1, 365)).ToString("dd/MM/yyyy"),
                    DateTo = DateTime.Now.AddDays(random.Next(1, 30)).ToString("dd/MM/yyyy"),
                    TimeFrom = $"{random.Next(0, 24):D2}:{random.Next(0, 60):D2}",
                    TimeTo = $"{random.Next(0, 24):D2}:{random.Next(0, 60):D2}",
                    CarModel = models[random.Next(models.Length)],
                    CarColor = colors[random.Next(colors.Length)],
                    TelephoneNum = $"{phonePrefixes[random.Next(phonePrefixes.Length)]}{random.Next(1000000, 9999999)}",
                    Address = $"123{random.Next(1, 999)} Test St, Dublin {random.Next(1, 25)}"
                };

                bookings.Add(testBooking);
            }

            return bookings;
        }


        private string GenerateIrishPlate(Random random)
        {
            var formats = new[]
            {
        $"{random.Next(100, 1000):D3}-{random.Next(65, 91):X1}{random.Next(65, 91):X1}-{random.Next(10000, 99999):D5}",
        $"{random.Next(100, 1000):D3}-{random.Next(65, 91):X1}{random.Next(65, 91):X1}{random.Next(65, 91):X1}-{random.Next(100, 1000):D3}",
        $"{random.Next(100, 200):D3}-{random.Next(65, 91):X1}{random.Next(65, 91):X1}-{random.Next(10000, 99999):D5}"
            };

            return formats[random.Next(formats.Length)];
        }

        public List<ParkingSpace> CreateTestParking()
        {
            var parkingSpaces = new List<ParkingSpace>();

            
            char[] buildings = { 'A', 'B' };
            char[] floors = { 'A', 'B', 'C' };

            int spaceId = 1;

            foreach (char building in buildings)
            {
                foreach (char floor in floors)
                {
                    for (int spaceNum = 1; spaceNum <= 50; spaceNum++)
                    {

                        var space = new ParkingSpace(spaceId++, $"{building}_{floor}{spaceNum:D2}", "Available");
                        parkingSpaces.Add(space);
                    }
                }
            }

            return parkingSpaces;  
        }


        private List<Operator> CreateTestOperators(int amount = 15)
        {
            var operators = new List<Operator>();

            var random = new Random();

            string[] firstNames = { "John", "Jane", "Bob", "Alice", "Mike", "Sarah", "Tom", "Emma", "David", "Lisa" };
            string[] lastNames = { "Doe", "Smith", "Wilson", "Brown", "Taylor", "Davis", "Clark", "Lewis", "Walker", "Hall" };
            string[] streets = { "High St", "Main St", "Park Ave", "Garden St", "King St", "Queen St", "O'Connell St", "Abbey St" };
            string[] phonePrefixes = { "087", "086", "085", "083", "089" };

            DateTime today = DateTime.Today;
            string todayStr = today.ToString("dd/MM/yyyy");

            for (int i = 0; i < amount; i++)
            {
                string fullName = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}";
                string address = $"{random.Next(1, 999)} {streets[random.Next(streets.Length)]}, Dublin {random.Next(1, 25)}";
                string telephoneStr = $"{phonePrefixes[random.Next(phonePrefixes.Length)]}{random.Next(1000000, 9999999)}";
                int telephone = int.Parse(telephoneStr);
                string email = $"{fullName.Replace(" ", ".").ToLower()}@example.com";

                var op = new Operator(
                    operatorID: i + 1,
                    fullName: fullName,
                    datejoined: todayStr,
                    address: address,
                    telephone: telephone,
                    email: email
                );

                operators.Add(op);
            }

            return operators;
        }
    }
}
