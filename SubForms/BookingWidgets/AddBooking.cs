using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Classes.Constants.ParkingSpace;
using Valet_Parking_System.Classes.Constants.Vehicle;
using Valet_Parking_System.Helpers;
using Valet_Parking_System.Services;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class AddBooking : UserControl
    {
        public AddBooking()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);

            txtDateFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TxtTimeFrom.Text = DateTime.Now.ToString("HH:mm");
            txtDateTo.Text = DateTime.Now.AddHours(1).ToString("dd/MM/yyyy");
            txtTimeTo.Text = DateTime.Now.AddHours(1).ToString("HH:mm");
        }

        //-----------------------------Events-----------------------------

        public event EventHandler<Booking> BookingCreateRequest;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(
                -1,
                txtFullName.Text.Trim(),
                txtTelephone.Text.Trim(),
                txtAddress.Text.Trim()
            );

            Vehicle vehicle = new Vehicle(
                -1,
                txtCarReg.Text.Trim().ToUpper(),
                txtCarModel.Text.Trim(),
                txtCarColor.Text.Trim(),
                VehicleStatus.AwaitingOperator
            );

            ParkingSpace parkingspace = ParkingServices.GetNextAvailableSpace();

            Debug.WriteLine(parkingspace.LotIdentifier);
            Booking booking = new Booking
            {
                Customer = customer,
                Vehicle = vehicle,
                ParkingSpace = parkingspace,
                DateFrom = txtDateFrom.Text,
                TimeFrom = txtTimeTo.Text,
                DateTo = txtDateTo.Text,
                TimeTo = txtTimeTo.Text,
                Status = BookingStatuses.AwaitingStorage
            };

            

            int validationCode = booking.ValidateBooking();

            if (validationCode == 0)
            {
                ValidationErrorLabel.Visible = false;
                BookingCreateRequest?.Invoke(this, booking);
                ClearFormFields();
            }
            else
            {
                ValidationErrorLabel.Text = booking.GetValidationErrorMsg();
                ValidationErrorLabel.Visible = true;
            }
        }

        //-----------------------------Helpers-----------------------------

        private void ClearFormFields()
        {
            txtFullName.Clear();
            txtTelephone.Clear();
            txtAddress.Clear();
            txtCarReg.Clear();
            txtCarModel.Clear();
            txtCarColor.Clear();
            txtDateFrom.Text = "";
            txtDateTo.Text = "";
            ValidationErrorLabel.Text = "";
            ValidationErrorLabel.Visible = false;

            txtDateFrom.Text = DateTime.Now.ToString("dd/MM/yyyy");
            TxtTimeFrom.Text = DateTime.Now.ToString("HH:mm");
            txtDateTo.Text = DateTime.Now.AddHours(1).ToString("dd/MM/yyyy");
            txtTimeTo.Text = DateTime.Now.AddHours(1).ToString("HH:mm");
        }

        
    }
}