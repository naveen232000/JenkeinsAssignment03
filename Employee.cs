using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }
        public DateTime Doj { get; set; }
        public void AddEmployee(int id,string name,string dept, double salary,DateTime doj ) 
        {
        List<Employee> list = new List<Employee>() { new Employee() { Id=id,Name=name,Dept=dept, Salary=salary,Doj=doj}, };
            foreach (Employee emp in list )
            {
                Console.WriteLine("{0,8} {1,8} {2,8} {3,8} {4,8}",emp.Id,emp.Name,emp.Dept,emp.Salary,emp.Doj);
            }
        }
    }
}
