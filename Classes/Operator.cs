using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valet_Parking_System.Classes
{
    public class Operator
    {
        public int operatorID;
        public string fullName;
        public string datejoined;
        public string fulladdress;
        public int telephone;
        public string email;

        public Operator(int operatorID, string fullName, string datejoined, string address,int telephone,string email)
        {
            this.operatorID = operatorID;
            this.fullName = fullName;
            this.datejoined = datejoined;
            this.fulladdress = address;
            this.telephone = telephone;
            this.email = email;
        }
    }
}
