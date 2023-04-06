using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class managementstaff : employee
    {
        public string Department { get; set; }
        public string Position { get; set; }

        public managementstaff(string name, string address, string phone, string email, DateTime hireDate, string department, string position) : base(name, address, phone, email, hireDate)
        {
            Department = department;
            Position = position;
        }

        public override int CalculateYearsOfService()
        {
            return DateTime.Now.Year - HireDate.Year;
        }

        public override int ShowDetails()
        {
            return CalculateYearsOfService();
        }
    }
}
