using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;

namespace Valet_Parking_System.SubForms
{
    public partial class OperatorSubForm : UserControl
    {
        List<Booking> Bookings;

        public OperatorSubForm()
        {
            InitializeComponent();
        }

        public void LoadBookings(List<Booking> bookings)
        {
            Bookings = bookings;

            var awaitingStorage = bookings
                .Where(b => b.Status == "AwaitingStorage")
                .ToList();

            var awaitingPickup = bookings
                .Where(b => b.Status == "AwaitingPickUp")
                .ToList();

            this.carStorageWidget.LoadBookings(awaitingStorage);
            this.carRetrievalWidget.LoadBookings(awaitingPickup);
        }
    }
}
