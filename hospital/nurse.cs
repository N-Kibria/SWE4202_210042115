using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class nurse : employee
    {
        public string position { get; set; }
        public string department { get; set; }
        
        
        

        public nurse(string name, string address, string phone, string email, DateTime hireDate, string position, string department) : base(name, address, phone, email, hireDate)
        {
            this.position = position;
            this.department = department;
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
