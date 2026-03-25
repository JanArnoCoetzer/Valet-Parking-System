
using Valet_Parking_System.Classes;


namespace Valet_Parking_System.SubForms.BookingWidgets.DataElements
{
    public partial class DeBookingTableRow : UserControl
    {               
        Booking bookingdata;
        BookingsTable bookingstable;
        public bool selected = false;
        
        
   

        public DeBookingTableRow(Booking booking, BookingsTable bt, bool BackPaneldark = false)
        {
            InitializeComponent();
            
            bookingdata = booking;
            bookingstable = bt;

            txtBookingId.Text = bookingdata.BookingId.ToString();
            txtCarReg.Text = bookingdata.CarReg.ToString();
            txtName.Text = bookingdata.FullName.ToString();
            txtFrom.Text = bookingdata.DateFrom.ToString();
            TxtTo.Text = bookingdata.DateTo.ToString();
            txtTime.Text = bookingdata.TimeTo.ToString();

            if (BackPaneldark)
            {
               panelColor = panelDark;
            }
            else 
            {
               panelColor = panelLight;
            }
            SetColor(panelColor);

        }

       


        //-----------------------------Events-----------------------------

        private void TableElement_MouseHover(object sender, EventArgs e)
        {
            if (!selected) SetColor(Color.FromArgb(135, 206, 235));
        }

        private void TableElement_MouseLeave(object sender, EventArgs e)
        {
            if (!selected) SetColor(panelColor);
        }

        private void TableElement_Clicked(object sender, MouseEventArgs e)
        {
            bookingstable.DeselectAllElements();
            selected = !selected;
            SetColor(selected ? Color.FromArgb(70, 130, 180) : panelColor);
            bookingstable.selectedElement(bookingdata);

        }

        //-----------------------------ExternalCalls-----------------------------

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }
        ///-----------------------------Rendering-----------------------------
        bool BackPaneldark = false;
        Color panelColor;
        Color panelLight = Color.FromArgb(245, 245, 245);
        Color panelDark = Color.FromArgb(235, 235, 235);
        
     
        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;       
        }
        

    }
}
