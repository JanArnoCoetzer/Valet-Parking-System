using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Valet_Parking_System
{
    public partial class MainLanding : Form
    {
        Panel Content;
        private DashBoardSubForm DashBoardUC = new();
        private BookingSubForm BookingsUC = new();
        private AdminSubForm AdminUC = new();
        private RetrievalQueueSubForm RetrievalQueueUC = new();

        private List<UserControl> subViews = new List<UserControl>();
        private Dictionary<Button, Panel> buttonPanels;
        private Panel activePanel;

        public List<Booking> LoadedBookings;
        public List<RetrievalQueueItem> QueueItems;
        private static readonly Random rand = new Random();

        public List<ParkingSpace> ParkingSpaces;

        public MainLanding()
        {
            InitializeComponent();
            BookingsUC.setMainLanding(this);
            ParkingSpaces = CreateTestParking();
            LoadedBookings = CreateTestBookings(ParkingSpaces ?? new List<ParkingSpace>());


            BookingsUC.LoadBookings(LoadedBookings);
            QueueItems = new List<RetrievalQueueItem>();
            

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


            // Initialize buttonPanels AFTER InitializeComponent()
            buttonPanels = new Dictionary<Button, Panel>
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
            if (sender is Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
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
            if (sender is Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
            {
                if (panel != activePanel)
                {
                    panel.BackColor = Color.FromArgb(8, 108, 236);
                }
            }
        }

        private void NavigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn && buttonPanels.TryGetValue(btn, out Panel panel))
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


        //-----------------------------External Calls Test-----------------------------
        public void RequestPickup(RetrievalQueueItem item)
        {
            var _item = item;
            QueueItems.Add(item);
            Debug.WriteLine($"QueueItems count: {QueueItems.Count}");
            RetrievalQueueUC.LoadQueueItems(QueueItems);
        }



        //-----------------------------Fuctions to test-----------------------------
        private List<Booking> CreateTestBookings(List<ParkingSpace> ParkingSpaces, int amount = 25)
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

            // Get available ParkingSpace objects
            var availableSpaces = new List<ParkingSpace>();
            if (ParkingSpaces != null && ParkingSpaces.Any())
            {
                availableSpaces = ParkingSpaces.Where(ps => ps.status == "Available").ToList();
                if (!availableSpaces.Any())
                    availableSpaces = ParkingSpaces.ToList();
            }

            for (int i = 0; i < 20; i++)
            {
                ParkingSpace space = availableSpaces.Any()
                    ? availableSpaces[random.Next(availableSpaces.Count)]
                    : null;

                var testBooking = new Booking
                {
                    BookingId = i + 1,
                    parkingspace = space,  // Full ParkingSpace object!
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

            int remaining = amount - 20;
            for (int i = 0; i < remaining; i++)
            {
                ParkingSpace space = availableSpaces.Any()
                    ? availableSpaces[random.Next(availableSpaces.Count)]
                    : null;

                var testBooking = new Booking
                {
                    BookingId = i + 21,
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
                        var space = new ParkingSpace
                        {
                            SpaceID = spaceId++,
                            LotIdentifier = $"{building}_{floor}{spaceNum:D2}",
                            status = "Available"
                        };

                        parkingSpaces.Add(space);
                    }
                }
            }

            return parkingSpaces;  
        }
    }
}
