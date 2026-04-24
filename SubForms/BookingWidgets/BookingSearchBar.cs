using System.Runtime.InteropServices;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingSearchBar : UserControl
    {
        private BookingSubForm parentForm;

        //-----------------------------Constructor-----------------------------

        public BookingSearchBar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        //-----------------------------Parent Setup-----------------------------

        public void SetParentForm(BookingSubForm bookingSubForm)
        {
            parentForm = bookingSubForm;
        }

        //-----------------------------Events-----------------------------

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.FilterBookings(txtID.Text, txtName.Text, txtReg.Text);
            }
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