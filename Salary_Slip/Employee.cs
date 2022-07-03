using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Slip
{
    internal class Employee
    {
        protected int baseSalary;
        protected int fuelAllowance;
        protected int medicalAllowance;
        protected int grossSalary;

        public Employee()
        {
            baseSalary = 1500;
            fuelAllowance = 0;
            medicalAllowance = 0;
            grossSalary = 0;
        }

        public virtual int calculateGrossSalary()
        {
            grossSalary = baseSalary + fuelAllowance + medicalAllowance;

            return grossSalary;
        }
        public void setBaseSalary(int baseSal)
        {
            this.baseSalary = baseSal;
        }
        public void setFuelAllowance(int fuel)
        {
            this.fuelAllowance = fuel;
        }
        public void setMedicalAllowance(int medical)
        {
            this.medicalAllowance = medical;
        }
         public int getBaseSalary()
        {
            return baseSalary;
        }
        public int getFuelAllowance()
        {
            return fuelAllowance;   
        }
        public int getMedicalAllowance()
        {
            return medicalAllowance;
        }

    }
}
