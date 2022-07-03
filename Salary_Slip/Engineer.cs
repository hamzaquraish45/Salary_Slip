using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip
{
    internal class Engineer:Employee
    {
        public Engineer()
        {
            this.fuelAllowance = 100;
            this.medicalAllowance = 500;

        }

        public override int calculateGrossSalary()
        {
            this.grossSalary = this.baseSalary + this.fuelAllowance + this.medicalAllowance;

            return this.grossSalary;
        }


    }
}
