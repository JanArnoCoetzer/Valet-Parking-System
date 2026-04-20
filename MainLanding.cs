using System.Diagnostics;
using System.Drawing.Text;
using System.Globalization;
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
        private System.Windows.Forms.Timer updateTimer;
        private Operator UsingOperator;
        //Subforms
        Panel Content;
        private LoginSubform LoginUC = new();
        private DashBoardSubForm DashBoardUC = new();
        private BookingSubForm BookingsUC = new();
        private RetrievalQueueSubForm RetrievalQueueUC = new();
        private OperatorSubForm OperatorUC = new();
        private AdminSubForm AdminUC = new();
        

        private List<UserControl> subViews = new List<UserControl>();
        private Dictionary<System.Windows.Forms.Button, Panel> buttonPanels;
        private Panel activePanel;
        private string activeSubform = "null";


        //DB loading
        public List<Booking> LoadedBookings;
        public List<RetrievalQueueItem> LoadedQueueItems; 
        public List<ParkingSpace> LoadedParkingSpaces;
        public List<Operator> LoadedOperators;
        public List<Customer> LoadedCustomers;
        public List<Vehicle> LoadedVehicles;

        //vars for testing
        public TestFunctions test = new TestFunctions();
        private int customeramount = 25;
        private bool useLogin = true;
        public MainLanding()
        {
            InitializeComponent();
            LoginUC.setMainLanding(this);
            BookingsUC.setMainLanding(this);
            LoadedParkingSpaces = test.CreateTestParking();
            LoadedCustomers = test.CreateTestCustomers(customeramount);
            LoadedVehicles = test.CreateTestVehcles(customeramount);
            LoadedOperators = test.CreateTestOperators(16);

            LoginUC.LoadOperators(LoadedOperators);

            LoadedBookings = test.CreateTestBookings(
                LoadedParkingSpaces ?? new List<ParkingSpace>(), 
                LoadedCustomers ?? new List<Customer>(),
                LoadedOperators ?? new List<Operator>(),
                LoadedVehicles ?? new List<Vehicle>(),
                customeramount);
            
            

            BookingsUC.LoadBookings(LoadedBookings);
            AdminUC.LoadParkingSpaces(LoadedParkingSpaces, LoadedOperators);
            LoadedQueueItems = new List<RetrievalQueueItem>();
             

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
            Content = this.ContentPanel;

            // Initialize subviews
            subViews.Add(DashBoardUC);
            subViews.Add(BookingsUC);
            subViews.Add(OperatorUC);
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
                { OperatorButton,OperatorHoverPanel},
                { AdminButton, AdminHoverPanel }
            };
            
           

            

            if (useLogin)
            {
                SetContent(LoginUC, Content);
            }
            else 
            {
                SetContent(DashBoardUC, Content);
                UserNameLabel.Visible = true;
            }

            DashBoardUC.Updatenearistbookings(LoadedBookings);
            UpdateHotbar();
            UpdateCycle(1);
        }


        public void LoginAsOperator(Operator usingOperator) 
        {
            UsingOperator = usingOperator;
            UserNameLabel.Text = usingOperator.fullName;
            UserNameLabel.Visible = true;
            SetContent(DashBoardUC, Content);
        }

        private void UpdateCycle(int secondsPerUpdate)
        {
            if (updateTimer == null)
            {
                updateTimer = new System.Windows.Forms.Timer();
                updateTimer.Tick += UpdateTimer_Tick;
            }

            updateTimer.Interval = secondsPerUpdate * 1000;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            //Prevents updating while Dashboard is not in view
            if (activeSubform != "DashBoardSubForm")
                return;

            UpdateHotbar();
        }

        private void UpdateHotbar() 
        {
            DashBoardUC.UpdatestatusHotbarWidget(
                CountTodayBookings(),
                CountSpaces(),
                CountQueueItems()
            );
        }
        private string CountSpaces() 
        {
            int freeSpaces = 0;
            foreach (ParkingSpace space in LoadedParkingSpaces)
            {
                if (space.Available)
                {
                    freeSpaces++;
                }
            }
            return freeSpaces.ToString();
        }
        private string CountQueueItems()
        {
            if (LoadedQueueItems == null)
                return "0";

            return LoadedQueueItems.Count.ToString();
        }

        private string CountTodayBookings()
        {
            try
            {
                if (LoadedBookings == null || LoadedBookings.Count == 0)
                    return "0";

                DateTime today = DateTime.Today;

                int count = LoadedBookings.Count(b =>
                    DateTime.ParseExact(
                        b.DateFrom,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture).Date == today);

                return count.ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CountTodayBookings failed: {ex.Message}");
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "0";
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

        private void SetContent(UserControl uc, Panel ContentPnl)
        {
            foreach (var view in subViews)
                view.Hide();

            ContentPnl.Controls.Clear();
            ContentPnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
            activeSubform = uc.Name;
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
                    case "OperatorButton":
                        SetContent(OperatorUC, Content);
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
    }
}
