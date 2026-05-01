using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.Operator;
using Valet_Parking_System.DataAccessLayer;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.Services;
using Valet_Parking_System.SubForms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Valet_Parking_System
{
    public partial class MainLanding : Form
    {
        private System.Windows.Forms.Timer _updateTimer;


        private Operator _usingOperator;// Operator loged in as


        //---------------------------------SubViews---------------------------------
        private Panel _content;
        private Panel _activePanel;
        private readonly LoginSubform _loginUC = new();
        private readonly DashBoardSubForm _dashBoardUC = new();
        private readonly BookingSubForm _bookingsUC = new();
        private readonly OperatorSubForm _operatorUC = new();
        private readonly AdminSubForm _adminUC = new();
        private readonly List<UserControl> _subViews = new();
        private Dictionary<Button, Panel> _buttonPanels;


        //---------------------------------DBTables---------------------------------
        public List<Booking> LoadedBookings { get; private set; }
        public List<ParkingSpace> LoadedParkingSpaces { get; private set; }
        public List<Operator> LoadedOperators { get; private set; }
        public List<Customer> LoadedCustomers { get; private set; }
        public List<Vehicle> LoadedVehicles { get; private set; }


        //---------------------------------ChangableVars---------------------------------

        // db connection sql string located in DataAccessLayer.OracleDbContext.DBConnectionString
   
        private const int CustomerAmount = 50; // Set Amount of customers :used in generating tables Values Above 450 throws a System.ComponentModel.Win32Exception: 'Error creating window handle.
                                                
        private const int OperatorAmount = 16;//Set Amount of Operators :used in generating tables
        private const int RefreshTablesRate = 25; // how long in seconds before the software automaticly refreshes data
        private const int ParkingSpacesFreeAmount = 50;

        private const bool UseLogin = true; //(UserName:Admin Password:Admin) OR  (Username:Operator Password:Operator) //both in generated tables and in DbCreatetables for oracle
        private bool UseMyDataBase = true;  
        private bool UseGeneratedTables = false;
        private bool DBValid = false;

        
        //---------------------------------Constructor---------------------------------

        public MainLanding()
        {
            InitializeComponent();
            SetMainLandingReferences();

            InitializeGui();

            StartUpdateCycle(RefreshTablesRate);
        }

        //---------------------------------Setup---------------------------------

        private void InitializeGui()
        {
            _content = ContentPanel;

            _subViews.Add(_dashBoardUC);
            _subViews.Add(_bookingsUC);
            _subViews.Add(_operatorUC);
            _subViews.Add(_adminUC);

            foreach (UserControl view in _subViews)
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
            _adminUC.SetMainLanding(this);
        }

        private void SetContent(UserControl userControl)
        {
            foreach (UserControl view in _subViews)
            {
                view.Hide();
            }

            _content.Controls.Clear();
            _content.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        //---------------------------------Data Loading---------------------------------


        public void TestDB()
        {

            if (UseMyDataBase)
            {

                DBValid = OracleDbContext.TestConnection();
                if (DBValid)
                {
                    ConnectionText.Text = "MyDatabaseConnected";
                    LoadTables();
                }
                else
                {
                    UseGeneratedTables = true;
                    UseMyDataBase = false;
                }
                
            }

            if (UseGeneratedTables)
            {
                ConnectionText.Text = "GeneratedTables";
                GenerateTables();
            }
        }
        public void LoadTables()
        {
            MainlandingData Data = new MainlandingData();
            if (UseGeneratedTables)
            {
                Data = MainLandingServices.LoadAllDataFromGenerators(CustomerAmount, OperatorAmount, CustomerAmount + ParkingSpacesFreeAmount);
            }
            if (UseMyDataBase) 
            {
                OracleDbContext.DBConnectionString = "Data Source = localhost/orcl; User ID = SYSTEM; Password = 159632478";
                Data = MainLandingServices.LoadAllDataFromDb();
            }
            
            UpdateTables(Data);
        }

        public void GenerateTables()
        {
            MainlandingData Data = new MainlandingData();
            Data = MainLandingServices.LoadAllDataFromGenerators(CustomerAmount, OperatorAmount,CustomerAmount + ParkingSpacesFreeAmount);
            UpdateTables(Data);
        }

        public void UpdateTables(MainlandingData Data)
        {
            LoadedBookings = Data.Bookings;
            LoadedParkingSpaces = Data.ParkingSpaces;
            LoadedOperators = Data.Operators;
            LoadedCustomers = Data.Customers;
            LoadedVehicles = Data.Vehicles;
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
                SetPermissions(OperatorPermissions.Admin);
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
            DashBoardButton.Enabled = MainLandingServices.CanAccessDashboard(permissions);
            BookingsButton.Enabled = MainLandingServices.CanAccessBookings(permissions);
            OperatorButton.Enabled = MainLandingServices.CanAccessOperators(permissions);
            AdminButton.Enabled = MainLandingServices.CanAccessAdmin(permissions);
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
            if (UseMyDataBase)
            {
                UpdateTables(MainLandingServices.LoadAllDataFromDb());
            }
        }

        //---------------------------------Navigation Events---------------------------------
        private void BtnMyDb_Click(object sender, EventArgs e)
        {
            UseGeneratedTables = false;
            UseMyDataBase = true;
            TestDB();
            SetLoginState();
        }

        private void BtnGenerateTables_Click(object sender, EventArgs e)
        {
            UseMyDataBase = false;
            UseGeneratedTables = true;
            TestDB();
            SetLoginState();
        }

       
        private void NavigationButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button || !_buttonPanels.TryGetValue(button, out Panel panel))
            {
                return;
            }

            foreach (Panel hoverPanel in _buttonPanels.Values)
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