using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.BookingWidgets;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Valet_Parking_System.SubForms
{
    public partial class BookingSubForm : UserControl
    {
        private static readonly Random rand = new Random();    
        private BookingsTable bookingsTable;
        private List<Booking> LoadedBookings;
        private BookingSearchBar bookingSearch;
        private MainLanding _MainLanding;
        public BookingSubForm()
        {
            InitializeComponent();       

            bookingsTable = this.BookingTableWidget;
            bookingSearch = this.SearchBookingsWidget;

            bookingSearch.setParentForm(this);
            bookingsTable.setparentform(this);
        }

        public void LoadBookings(List<Booking> bookings) 
        {
            LoadedBookings = bookings;
            bookingsTable.DisplayBookings(LoadedBookings);
        }
        public void setMainLanding(MainLanding mainLanding) 
        {
            _MainLanding = mainLanding;
        }



        //-----------------------------Events-----------------------------
        private void BookingSubForm_Load(object sender, EventArgs e)
        {
            NewBookingWidget.BookingCreateRequest += OnBookingCreated;
        }



        //-----------------------------External Calls-----------------------------     

        public void FilterBookings(string bookingIdText = "", string customerNameText = "", string carRegText = "")
        {
            if (LoadedBookings == null) return;

            IEnumerable<Booking> query = LoadedBookings;

            // Booking ID filter
            if (!string.IsNullOrEmpty(bookingIdText) && int.TryParse(bookingIdText, out int id))
            {
                query = query.Where(b => b.BookingId == id);
            }

            // Customer Name filter
            if (!string.IsNullOrEmpty(customerNameText))
            {
                query = query.Where(b =>
                    !string.IsNullOrEmpty(b.FullName) &&
                    b.FullName.IndexOf(customerNameText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Car Registration filter 
            if (!string.IsNullOrEmpty(carRegText))
            {
                query = query.Where(b =>
                    !string.IsNullOrEmpty(b.CarReg) &&
                    b.CarReg.IndexOf(carRegText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var filtered = query.ToList();

            bookingsTable.DisplayBookings(filtered);   
        }









        //-----------------------------Database Calls-----------------------------  

        //implament database functionality

        public void requestPickup(RetrievalQueueItem item)
        {
            //Calls to move booking to retreval queue returns true/false for conformation on succesfully saved to db and 
            //delete booking

            if (true)
                MessageBox.Show("PickipRequested", "Success");
            else
                MessageBox.Show("Failed to Create Request.", "Error");
        }

        private void OnBookingCreated(object sender, Booking booking)
        {
            //Calls to add booking then returns true/false for conformation on succesfully saved to db

            if (true)
                MessageBox.Show("Booking created successfully!", "Success");
            else
                MessageBox.Show("Failed to create booking.", "Error");
        }

        public void EditBooking(Booking booking) 
        {
            //Calls to edit booking then returns true/false for conformation on succesfully updated in db
            if (true)
                MessageBox.Show("Booking updated successfully!", "Success");
            else
                MessageBox.Show("Failed to update booking.", "Error");
        }
    }
}
