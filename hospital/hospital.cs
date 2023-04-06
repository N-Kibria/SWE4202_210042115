using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class hospital
    {
        private List<employee> employees= new List<employee>();

     

        public void AddEmployee(employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(employee employee)
        {
            employees.Remove(employee);
        }

        public void ListEmployees()
        {
            foreach (employee employee in employees)
            {
                Console.WriteLine(employee.ShowDetails());
            }
        }

        public List<employee> SearchByName(string name)
        {
            return employees.Where(e => e.Name.Contains(name)).ToList();
        }

        public List<employee> SearchByJoiningYear(int year)
        {
            return employees.Where(e => e.HireDate.Year == year).ToList();
        }

        public List<employee> SearchByPosition(string position)
        {
            return employees.Where(e => e.position.Contains(position)).ToList();
        }

        public List<employee> SearchByDepartment(string department)
        {
            return employees.Where(e => e.department.Contains(department)).ToList();
        }
    }
}
