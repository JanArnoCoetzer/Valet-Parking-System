using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class EditBookingWidget : UserControl
    {
        private BookingsTable _bookingsTable;
        private Booking _bookingData;
        private EditBookingWindow1 _parentForm;

        //-----------------------------Constructor-----------------------------

        public EditBookingWidget()
        {
            InitializeComponent();
            InitializeFields();

            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20)
            );
        }

        //-----------------------------Setup-----------------------------

        public void SetParentTable(BookingsTable bookingsTable)
        {
            _bookingsTable = bookingsTable;
        }

        public void SetBookingData(Booking booking)
        {
            _bookingData = booking;
            InitializeFields();
        }

        public void SetParentForm(EditBookingWindow1 parentForm)
        {
            _parentForm = parentForm;
        }

        //-----------------------------Actions-----------------------------

        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            _bookingsTable?.CancelEditBooking();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                txtStatus.Text.Trim()
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
                _bookingsTable?.EditBooking(booking);
                _parentForm?.CloseAndDispose();
            }
            else
            {
                ValidationErrorLabel.Text = booking.GetValidationErrorMsg();
                ValidationErrorLabel.Visible = true;
            }
        }

        //-----------------------------Helpers-----------------------------

        private void InitializeFields()
        {
            if (_bookingData == null)
            {
                return;
            }

            txtFullName.Text = _bookingData.Customer.FullName;
            txtTelephone.Text = _bookingData.Customer.Telephone;
            txtAddress.Text = _bookingData.Customer.Address;
            txtCarReg.Text = _bookingData.Vehicle.Registation;
            txtCarModel.Text = _bookingData.Vehicle.Model;
            txtCarColor.Text = _bookingData.Vehicle.Color;
            dateFromPicker.Text = _bookingData.DateFrom;
            dateToPicker.Text = _bookingData.DateTo;
            txtSpaceId.Text = _bookingData.ParkingSpace.LotIdentifier;
            txtStatus.Text = _bookingData.Vehicle.Status;
        }

        //-----------------------------Rendering-----------------------------

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