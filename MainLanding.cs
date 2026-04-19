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
        public List<Customer> LoadedCustomers;

        //vars for testing
        public TestFunctions test = new TestFunctions();
        private int customeramount = 25;
        public MainLanding()
        {
            InitializeComponent();

            BookingsUC.setMainLanding(this);
            LoadedParkingSpaces = test.CreateTestParking();
            LoadedCustomers = test.CreateTestCustomers(customeramount);
            LoadedBookings = test.CreateTestBookings(LoadedParkingSpaces ?? new List<ParkingSpace>(), LoadedCustomers ?? new List<Customer>(), LoadedOperators ?? new List<Operator>(), customeramount);
            LoadedOperators = test.CreateTestOperators(16);
            

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
    }
}
