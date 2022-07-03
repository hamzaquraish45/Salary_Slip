using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip
{
    internal class Manager : Employee
    {
        public Manager()
        {
            this.fuelAllowance = 250;
            this.medicalAllowance = 1000;
        }

        public override int calculateGrossSalary()
        {
            this.grossSalary = this.baseSalary + this.fuelAllowance + this.medicalAllowance;

            return this.grossSalary;
        }
    }
}
