using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCL
{
    class Financial : Officers, DetailsOfficers
    {
        private double FestibleBonus { get; set; }
        public Financial(double FestibleBonus, int Id, string Name, int WorkHour, double PaymentHour, string Performance) : base(Id, Name, WorkHour, PaymentHour, Performance)
        {
            this.FestibleBonus = FestibleBonus;
        }

       // Salary S = new Salary(100, 20000);



        public double YearlySalary()
        {
            return MonthlySalary() * 12 + (2 * FestibleBonus);
        }

        public void TotalTax()
        {
            if (YearlySalary() > 250000)
            {
                double tax = YearlySalary() * .10;
                Console.WriteLine("Tax is require :" + tax);
            }
            else
            {
                Console.WriteLine("No Count text");
            }
        }




    }
}
