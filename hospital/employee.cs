using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal abstract class employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public employee(string name, string address, string phone, string email, DateTime hireDate)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            HireDate = hireDate;
        }
        public abstract int CalculateYearsOfService();

        public abstract int ShowDetails();
    }
}
