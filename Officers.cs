using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCL
{
    class Officers
    {
        private int Id {get; set;}
        private String Name { get; set; }
        //private int salary_info{ get; set; }
        private int WorkHour { get; set; }
        private double PaymentHour { get; set; }
        private string Performance { get; set; }

        public Officers(int Id, string Name, int WorkHour, double PaymentHour, string Performance)
        {
            this.Id = Id;
            this.Name = Name;
            this.WorkHour = WorkHour;
            this.PaymentHour = PaymentHour;
            this.Performance = Performance;
        }
        public double MonthlySalary()
        {

            return WorkHour * PaymentHour;
        }
    }
}
