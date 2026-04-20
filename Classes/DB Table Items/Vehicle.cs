using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet_Parking_System.Classes
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Registation { get; set; } 
        public string Model { get; set; } 
        public string Color { get; set; }
        public string Status { get; set; }

        public Vehicle(int iD, string registation, string model, string color, string status) 
        {
            ID = iD;
            Registation = registation;
            Model = model;
            Color = color;
            Status = status;
        }
    }
}
