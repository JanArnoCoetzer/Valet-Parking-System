using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;


namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class EditBookingWidget : UserControl
    {
        BookingsTable bt;
        Booking BookingData;
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


        private void btnCancelEditBooking_Click(object sender, EventArgs e)
        {
            bt.CancelEditBooking();
        }

        private void InitializeFields()
        {
            if (BookingData != null)
            {

                txtFullName.Text = BookingData.FullName;
                txtTelephone.Text = BookingData.TelephoneNum;
                txtAddress.Text = BookingData.Address;
                txtCarReg.Text = BookingData.CarReg;
                txtCarModel.Text = BookingData.CarModel;
                txtCarColor.Text = BookingData.CarColor;
                dateFromPicker.Text = BookingData.DateFrom;
                dateToPicker.Text = BookingData.DateTo;
                txtSpaceId.Text = BookingData.ParkingSpaceId.ToString();
                txtStatus.Text = BookingData.Status;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var booking = new Booking
            {
                FullName = txtFullName.Text.Trim(),
                TelephoneNum = txtTelephone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                CarReg = txtCarReg.Text.Trim().ToUpper(),
                CarModel = txtCarModel.Text.Trim(),
                CarColor = txtCarColor.Text.Trim(),
                DateFrom = dateFromPicker.Text,
                DateTo = dateToPicker.Text,
                //time from //time to //
            };

            int validationCode = booking.ValidateBooking();

            if (validationCode == 0)
            {
                ValidationErrorLabel.Visible = false;
                                
            }
            else
            {
                ValidationErrorLabel.Visible = true;
                ValidationErrorLabel.Text = booking.GetValidationErrorMsg();
            }
        }
    }
}
