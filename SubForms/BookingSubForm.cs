using System.Diagnostics;
using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;
using Valet_Parking_System.SubForms.BookingWidgets;
using Valet_Parking_System.SubForms.BookingWidgets.DataElements;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Valet_Parking_System.SubForms
{
    public partial class BookingSubForm : UserControl
    {
        private static readonly Random rand = new Random();    
        private BookingsTable BookingsTable;
        private List<Booking> LoadedBookings;
        private BookingSearchBar BookingSearch;
        public MainLanding MainLanding;
        public BookingSubForm()
        {
            InitializeComponent();
            BookingsTable = this.BookingTableWidget;
            BookingSearch = this.SearchBookingsWidget;

            BookingSearch.setParentForm(this);
            BookingsTable.setparentform(this);
        }

        public void LoadBookings(List<Booking> bookings) 
        {
            LoadedBookings = bookings;
            BookingsTable.DisplayBookings(LoadedBookings);
        }
        public void setMainLanding(MainLanding mainLanding) 
        {
            MainLanding = mainLanding;
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
                    !string.IsNullOrEmpty(b.Customer.FullName) &&
                    b.Customer.FullName.IndexOf(customerNameText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Car Registration filter 
            if (!string.IsNullOrEmpty(carRegText))
            {
                query = query.Where(b =>
                    !string.IsNullOrEmpty(b.Vehicle.Registation) &&
                    b.Vehicle.Registation.IndexOf(carRegText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            var filtered = query.ToList();

            BookingsTable.DisplayBookings(filtered);   
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
            bool addedtoDB =  BookingRepository.AddBooking(booking);
         

            if (addedtoDB)
                MessageBox.Show("Booking created successfully!", "Success");
            else
                MessageBox.Show("Failed to create booking.", "Error");
        }

        public void EditBooking(Booking booking) 
        {
            bool EditedInDb = BookingRepository.EditBooking(booking);

            //Calls to edit booking then returns true/false for conformation on succesfully updated in db
            if (EditedInDb)
                MessageBox.Show("Booking updated successfully!", "Success");
            else
                MessageBox.Show("Failed to update booking.", "Error");
        }
    }
}
