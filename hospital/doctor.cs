using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    public class doctor : employee
    {
        public string Department { get; set; }
        public string Position { get; set; }
        public List<string> Degrees { get; set; }
        public List<string> WorksWith { get; set; }

        public doctor(string name, string address, string phone, string email, DateTime hireDate, string department, string position, List<string> degrees, List<string> worksWith) : base(name, address, phone, email, hireDate)
        {
            Department = department;
            Position = position;
            Degrees = degrees;
            WorksWith = worksWith;
        }

       
    }
}
