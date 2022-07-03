using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip
{
    internal class Analyst:Employee
    {
        public Analyst()
        {
            this.fuelAllowance = 150;
            this.medicalAllowance = 800;
        }

        public override int calculateGrossSalary()
        {
            this.grossSalary = this.baseSalary + this.fuelAllowance + this.medicalAllowance;

            return this.grossSalary;
        }
    }
}
