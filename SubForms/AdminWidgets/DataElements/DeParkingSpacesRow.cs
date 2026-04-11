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
using Valet_Parking_System.SubForms.BookingWidgets;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    
    public partial class DeParkingSpacesRow : UserControl
    {
        ParkingSpacesTable parkingTable;
        ParkingSpace parking;
        public bool selected = false;
        public DeParkingSpacesRow(ParkingSpace parkingspace,ParkingSpacesTable pt, bool BackPaneldark = false)
        {
            InitializeComponent();
            parkingTable = pt;
            parking = parkingspace;
            
            this.txtSpaceID.Text = parking.SpaceID.ToString();
            this.txtLotIdentifier.Text = parking.LotIdentifier;
            this.txtStatus.Text = parking.Status;

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

        public void Deselect() 
        {
            selected = false;
            SetColor(panelColor);
        }

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
            parkingTable.DeselectAllElements();
            selected = !selected;
            SetColor(selected ? Color.FromArgb(70, 130, 180) : panelColor);
            if (selected) 
            {          
                parkingTable.SelectedSpaceUpdate(parking);
            }
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
