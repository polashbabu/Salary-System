using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCL
{
    class MarkatingOfficers : Officers, DetailsOfficers

    {
        private double WorkHourBonus { get; set; }
        public MarkatingOfficers(double WorkHourBonus, int Id, string Name, int WorkHour, double PaymentHour, string Performance) : base(Id, Name, WorkHour, PaymentHour, Performance)
        {
            this.WorkHourBonus = WorkHourBonus;

        }



        public double YearlySalary()
        {
            return MonthlySalary() * 12 + (2 * WorkHourBonus);
        }

        public void TotalTax()
        {
            if (YearlySalary() > 300000)
            {
                double tax = YearlySalary() * .15;
                Console.WriteLine("Tax is require:" + tax);
            }
            else
            {
                Console.WriteLine("No Count text");
            }
        }


    }
}
