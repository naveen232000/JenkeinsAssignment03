// See https://aka.ms/new-console-template for more information
using Assignment03;

Console.WriteLine("Employee Details");
Console.WriteLine("{0,-8} {1,-8} {2,-8} {3,-8} {4,-8}", "ID", "Name", "Department", "Salary", "Date Of Joining");
Employee employee = new Employee();
employee.AddEmployee(1, "Naveen", "Testing", 32659, new DateTime(day:23,month:01,year:2024));
