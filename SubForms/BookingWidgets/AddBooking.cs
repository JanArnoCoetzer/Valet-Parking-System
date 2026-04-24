using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class AddBooking : UserControl
    {
        public AddBooking()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
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
                "pending"
            );

            Booking booking = new Booking
            {
                Customer = customer,
                Vehicle = vehicle,
                DateFrom = dateFromPicker.Text,
                DateTo = dateToPicker.Text
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
            dateFromPicker.Text = "";
            dateToPicker.Text = "";
            ValidationErrorLabel.Text = "";
            ValidationErrorLabel.Visible = false;
        }

        
    }
}