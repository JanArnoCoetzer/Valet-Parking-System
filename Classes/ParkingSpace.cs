using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet_Parking_System.Classes
{
    public class ParkingSpace
    {
        public int SpaceID;
        public string LotIdentifier;
        public string Status;
        public bool Available { get; set; } = false;

        public ParkingSpace(int spaceID, string lotIdentifier, string status)
        {
            SpaceID = spaceID;
            LotIdentifier = lotIdentifier;       
            setStatus(status);
        }


        public void setStatus(string status)
        {
            
            switch (status)
            {
                case "Available":
                    Available = true;
                    Status = status;
                    break;

                case "Occupied":
                    Available = false;
                    Status = status;
                    break;

                case "Out of Service":
                    Available = false;
                    Status = status;
                    break;

                default:
                    Available = false;
                    Status = "Error";
                    Debug.WriteLine("Error settign status in Class ParkingSpace.setStatus() with status being ("+status+")");
                    break;
            }
        }
    }
}
