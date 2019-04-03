using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCL
{
    class Salary
    {
        private double PerHourSalary { get; set; }
        private double TotalYearlySalary { get; set; }

        public Salary(double PerHourSalary, double TotalYearlySalary)
        {
            this.PerHourSalary = PerHourSalary;
            this.TotalYearlySalary = TotalYearlySalary;
        }
    }
}