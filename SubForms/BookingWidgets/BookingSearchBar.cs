using System.Runtime.InteropServices;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.BookingWidgets
{
    public partial class BookingSearchBar : UserControl
    {
        private BookingSubForm parentForm;

        //-----------------------------Constructor-----------------------------

        public BookingSearchBar()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
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

       
    }
}