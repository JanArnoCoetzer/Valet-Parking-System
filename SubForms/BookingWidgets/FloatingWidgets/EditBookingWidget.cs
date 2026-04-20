using System.Net;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;


namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class EditBookingWidget : UserControl
    {
        BookingsTable bt;
        Booking BookingData;
        EditBookingWindow1 parentform;
        public EditBookingWidget()
        {
            InitializeComponent();
            InitializeFields();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
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

        public void setParentTable(BookingsTable bt)
        {
            this.bt = bt;

        }
        public void setBookingData(Booking bk)
        {
            BookingData = bk;
            InitializeFields();
        }

        public void setParentForm(EditBookingWindow1 parent) 
        {
            parentform = parent;
        }


        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            bt.CancelEditBooking();
        }

        private void InitializeFields()
        {
            if (BookingData != null)
            {

                txtFullName.Text = BookingData.Customer.FullName;
                txtTelephone.Text = BookingData.Customer.Telephone;
                txtAddress.Text = BookingData.Customer.Address;
                txtCarReg.Text = BookingData.Vehicle.Registation;
                txtCarModel.Text = BookingData.Vehicle.Model;
                txtCarColor.Text = BookingData.Vehicle.Color;
                dateFromPicker.Text = BookingData.DateFrom;
                dateToPicker.Text = BookingData.DateTo;
                txtStatus.Text = BookingData.Status;
                txtSpaceId.Text = BookingData.ParkingSpace.LotIdentifier;
                txtStatus.Text = BookingData.Vehicle.Status;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customer = new Customer(
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

            var booking = new Booking
            {
                Customer = customer,
                Vehicle = vehicle,
                DateFrom = dateFromPicker.Text,
                DateTo = dateToPicker.Text,
                //time from //time to //
            };

            int validationCode = booking.ValidateBooking();

            if (validationCode == 0)
            {
                ValidationErrorLabel.Visible = false;
                bt.EditBooking(booking);
                parentform.CloseAndDispose();
            }
            else
            {
                ValidationErrorLabel.Visible = true;
                ValidationErrorLabel.Text = booking.GetValidationErrorMsg();
            }


        }
    }
}
