using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class nurse : employee
    {
        public string position { get; set; }
        public string department { get; set; }


        public nurse(string name, string address, string phone, string email, DateTime hireDate, string department, string position) : base(name, address, phone, email, hireDate)
        {
            this.department = department;
            this.position = position;
            
        }


    }
}
