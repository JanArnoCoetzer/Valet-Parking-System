using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class AddBooking : UserControl
    {


        public AddBooking()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));

        }

        public event EventHandler<Booking> BookingCreateRequest;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(-1,txtFullName.Text.Trim(), txtTelephone.Text.Trim(), txtAddress.Text.Trim());

            var booking = new Booking
            {
                Customer = customer,
                CarReg = txtCarReg.Text.Trim().ToUpper(),
                CarModel = txtCarModel.Text.Trim(),
                CarColor = txtCarColor.Text.Trim(),
                DateFrom = dateFromPicker.Text,
                DateTo = dateToPicker.Text,
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
                ValidationErrorLabel.Visible = true;
                ValidationErrorLabel.Text = booking.GetValidationErrorMsg();
            }
        }

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
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
