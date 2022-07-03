using System;

namespace Salary_Slip
{
    internal class Program : Employee
    {
        static void Main(string[] args)
        {
            string designation;
            int grossSalary = 0;

            Console.WriteLine("Enter Designation: ");
            designation = Console.ReadLine();

            if (designation == "engineer")
            {
                Engineer obj = new Engineer();
                grossSalary = obj.calculateGrossSalary();
                Console.WriteLine("Gross salary of " + designation + " is: $" + grossSalary);

            }

            else if (designation == "analyst")
            {
                Analyst obj = new Analyst();
                grossSalary = obj.calculateGrossSalary();
                Console.WriteLine("Gross salary of " + designation + " is: $" + grossSalary);

            }
            else if (designation == "manager")
            {
                Manager obj = new Manager();
                grossSalary = obj.calculateGrossSalary();
                Console.WriteLine("Gross salary of " + designation + " is: $" + grossSalary);

            }

        }
    }
}
