using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.SubForms;

namespace Valet_Parking_System
{
    public partial class MainLanding : Form
    {

        private System.Windows.Forms.Timer _updateTimer;
        private Operator _usingOperator;
        private Panel _content;
        private Panel _activePanel;

        private readonly LoginSubform _loginUC = new();
        private readonly DashBoardSubForm _dashBoardUC = new();
        private readonly BookingSubForm _bookingsUC = new();
        private readonly OperatorSubForm _operatorUC = new();
        private readonly AdminSubForm _adminUC = new();

        private readonly List<UserControl> _subViews = new();
        private Dictionary<Button, Panel> _buttonPanels;

        public List<Booking> LoadedBookings { get; private set; }
        public List<ParkingSpace> LoadedParkingSpaces { get; private set; }
        public List<Operator> LoadedOperators { get; private set; }
        public List<Customer> LoadedCustomers { get; private set; }
        public List<Vehicle> LoadedVehicles { get; private set; }

        private const int CustomerAmount = 50;
        private const int OperatorAmount = 16;
        private const bool UseLogin = false;

        //---------------------------------Constructor---------------------------------

        public MainLanding()
        {
            InitializeComponent();
            SetMainLandingReferences();
            InitializeGui();
            LoadTables();
            SetLoginState();
            StartUpdateCycle(10);
        }

        //---------------------------------Setup---------------------------------

        private void InitializeGui()
        {
            _content = ContentPanel;

            _subViews.Add(_dashBoardUC);
            _subViews.Add(_bookingsUC);
            _subViews.Add(_operatorUC);
            _subViews.Add(_adminUC);

            foreach (var view in _subViews)
            {
                view.Dock = DockStyle.Fill;
            }

            _buttonPanels = new Dictionary<Button, Panel>
        {
            { DashBoardButton, DashHoverPanel },
            { BookingsButton, BookingsHoverPanel },
            { OperatorButton, OperatorHoverPanel },
            { AdminButton, AdminHoverPanel }
        };

            FormBorderStyle = FormBorderStyle.None;
            RegionHelper.ApplyRoundedRegion(this, 20);
        }

        private void SetMainLandingReferences()
        {
            _loginUC.SetMainLanding(this);
            _bookingsUC.SetMainLanding(this);
            _operatorUC.SetMainLanding(this);
        }

        private void SetContent(UserControl userControl)
        {
            foreach (var view in _subViews)
            {
                view.Hide();
            }

            _content.Controls.Clear();
            _content.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        //---------------------------------Data Loading---------------------------------

        public void LoadTables()
        {
            LoadedParkingSpaces = TestFunctions.CreateTestParking();
            LoadedCustomers = TestFunctions.CreateTestCustomers(CustomerAmount);
            LoadedVehicles = TestFunctions.CreateTestVehcles(CustomerAmount);
            LoadedOperators = TestFunctions.CreateTestOperators(OperatorAmount);

            LoadedBookings = TestFunctions.CreateTestBookings(
                LoadedParkingSpaces ?? new List<ParkingSpace>(),
                LoadedCustomers ?? new List<Customer>(),
                LoadedOperators ?? new List<Operator>(),
                LoadedVehicles ?? new List<Vehicle>(),
                CustomerAmount);

            UpdateSubformTables(LoadedBookings, LoadedOperators, LoadedParkingSpaces);
        }

        internal void UpdateSubformTables(
            List<Booking> bookings,
            List<Operator> operators,
            List<ParkingSpace> spaces)
        {
            _dashBoardUC.UpdateData(bookings, spaces);
            _bookingsUC.LoadLists(bookings, spaces);
            _operatorUC.LoadBookings(bookings);
            _adminUC.LoadParkingSpaces(spaces, operators);
        }

        //---------------------------------Login / Permissions---------------------------------

        private void SetLoginState()
        {
            if (UseLogin)
            {
                _loginUC.LoadOperators(LoadedOperators);
                SetContent(_loginUC);
            }
            else
            {
                SetContent(_dashBoardUC);
                UserNameLabel.Visible = true;
                SetPermissions("A");
            }
        }

        public void LoginAsOperator(Operator usingOperator)
        {
            _usingOperator = usingOperator;

            UserNameLabel.Text = usingOperator.fullName;
            UserNameLabel.Visible = true;

            SetPermissions(usingOperator.Permissions);
            SetContent(_dashBoardUC);

            _dashBoardUC.UsingOperator = usingOperator;
            _bookingsUC.UsingOperator = usingOperator;
            _operatorUC.UsingOperator = usingOperator;
            _adminUC.UsingOperator = usingOperator;
        }

        public void SetPermissions(string permissions)
        {
            switch (permissions)
            {
                case "A":
                    DashBoardButton.Enabled = true;
                    BookingsButton.Enabled = true;
                    OperatorButton.Enabled = true;
                    AdminButton.Enabled = true;
                    break;

                case "O":
                    DashBoardButton.Enabled = true;
                    BookingsButton.Enabled = true;
                    OperatorButton.Enabled = true;
                    AdminButton.Enabled = false;
                    break;
            }
        }

        //---------------------------------Timer---------------------------------

        private void StartUpdateCycle(int secondsPerUpdate)
        {
            if (_updateTimer == null)
            {
                _updateTimer = new System.Windows.Forms.Timer();
                _updateTimer.Tick += UpdateTimer_Tick;
            }

            _updateTimer.Interval = secondsPerUpdate * 1000;
            _updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadTables();
        }

        //---------------------------------Navigation Events---------------------------------

        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button || !_buttonPanels.TryGetValue(button, out Panel panel))
            {
                return;
            }

            foreach (var hoverPanel in _buttonPanels.Values)
            {
                hoverPanel.BackColor = Color.FromArgb(254, 254, 254);
            }

            panel.BackColor = Color.FromArgb(8, 108, 236);
            _activePanel = panel;

            switch (button.Name)
            {
                case "DashBoardButton":
                    SetContent(_dashBoardUC);
                    break;
                case "BookingsButton":
                    SetContent(_bookingsUC);
                    break;
                case "OperatorButton":
                    SetContent(_operatorUC);
                    break;
                case "AdminButton":
                    SetContent(_adminUC);
                    break;
            }
        }

        private void NavigationButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button &&
                _buttonPanels.TryGetValue(button, out Panel panel) &&
                panel != _activePanel)
            {
                panel.BackColor = Color.FromArgb(8, 108, 236);
            }
        }

        private void NavigationButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button &&
                _buttonPanels.TryGetValue(button, out Panel panel) &&
                panel != _activePanel)
            {
                panel.BackColor = Color.FromArgb(254, 254, 254);
            }
        }

     
    }
}