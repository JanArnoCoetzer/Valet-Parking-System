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

        public MainLanding()
        {
            InitializeComponent();
            BookingsUC.setMainLanding(this);
            LoadedBookings = CreateTestBookings(25);
            

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
        private List<Booking> CreateTestBookings(int amount = 25)
        {
            var bookings = new List<Booking>();

            string[] firstNames = { "John", "Jane", "Bob", "Alice", "Mike", "Sarah", "Tom", "Emma", "David", "Lisa" };
            string[] lastNames = { "Doe", "Smith", "Wilson", "Brown", "Taylor", "Davis", "Clark", "Lewis", "Walker", "Hall" };
            string[] models = { "Toyota Corolla", "Ford Focus", "VW Golf", "Honda Civic", "BMW 3 Series", "Mercedes C-Class", "Audi A4", "Skoda Octavia", "Hyundai i30", "Kia Sportage" };
            string[] colors = { "Blue", "Red", "Black", "White", "Grey", "Silver", "Green", "Yellow", "Purple", "Orange" };
            string[] phonePrefixes = { "087", "086", "085", "083", "089" };

            for (int i = 0; i < amount; i++)
            {
                var testBooking = new Booking
                {
                    BookingId = i + 1,
                    CarReg = GenerateIrishPlate(),
                    FullName = $"{firstNames[rand.Next(firstNames.Length)]} {lastNames[rand.Next(lastNames.Length)]}",
                    DateFrom = DateTime.Now.AddDays(-rand.Next(1, 365)).ToString("dd/MM/yyyy"),
                    DateTo = DateTime.Now.AddDays(rand.Next(1, 30)).ToString("dd/MM/yyyy"),
                    TimeTo = DateTime.Now.AddHours(rand.Next(0, 24)).AddMinutes(rand.Next(0, 60)).ToString("HH:mm"),
                    CarModel = models[rand.Next(models.Length)],
                    CarColor = colors[rand.Next(colors.Length)],
                    TelephoneNum = $"{phonePrefixes[rand.Next(phonePrefixes.Length)]}{rand.Next(1000000, 9999999)}",
                    Address = $"123{rand.Next(1, 999)} Test St, Dublin {rand.Next(1, 25)}"
                };

                bookings.Add(testBooking);
            }

            return bookings;
        }    
        private string GenerateIrishPlate()
        {

            var formats = new[]
            {
        $"{rand.Next(100, 1000):D3}-{rand.Next(65, 91):X1}{rand.Next(65, 91):X1}-{rand.Next(10000, 99999):D5}",
        $"{rand.Next(100, 1000):D3}-{rand.Next(65, 91):X1}{rand.Next(65, 91):X1}{rand.Next(65, 91):X1}-{rand.Next(100, 1000):D3}",
        $"{rand.Next(100, 200):D3}-{rand.Next(65, 91):X1}{rand.Next(65, 91):X1}-{rand.Next(10000, 99999):D5}"  // older style
            };

            return formats[rand.Next(formats.Length)];
        }

    }
}
