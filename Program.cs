using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCL
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkatingOfficers sal = new MarkatingOfficers(90000, 101, "Jahid", 10, 400, "Good");
            Console.WriteLine("Monthly Total Salary:" + sal.MonthlySalary());
            Console.WriteLine("Yearly Total Salary:" + sal.YearlySalary());

            sal.TotalTax();

            MarkatingOfficers sal1 = new MarkatingOfficers(400000, 101, "Hassan", 10, 400, "Good");
            Console.WriteLine("Monthly Total Salary:" + sal1.MonthlySalary());
            Console.WriteLine("Yearly Total Salary:" + sal1.YearlySalary());

            sal1.TotalTax();
            Financial fo = new Financial(1000, 102, "Tsmim", 10, 2000, "good");
            Console.WriteLine("Monthly Total Salary:" + fo.MonthlySalary());
            Console.WriteLine("Yearly Total Salary:" + fo.YearlySalary());
            fo.TotalTax();

            Financial sal2 = new Financial(100000, 102, "Prince", 10, 2000, "good");
            Console.WriteLine("Monthly Total Salary:" + sal2.MonthlySalary());
            Console.WriteLine("Yearly Total Salary:" + sal2.YearlySalary());
            sal2.TotalTax();

            Console.ReadKey();





        }
    }
}
    
