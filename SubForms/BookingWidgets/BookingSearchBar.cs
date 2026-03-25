using System.Runtime.InteropServices;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingSearchBar : UserControl
    {
        BookingSubForm pf;

        public void setParentForm(BookingSubForm pf)
        {
            this.pf = pf;
        }

        public BookingSearchBar()
        {
            InitializeComponent();
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

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            pf.FilterBookings(txtID.Text,txtName.Text,txtReg.Text);
        }
    }
}
