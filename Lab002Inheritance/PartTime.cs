using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab002Inheritance
{
    public class Parttime : Employee
    {
        public double Rate { get; set; }
        public double Hours { get; set; }
        public static double partTimeCounter;

        public Parttime()
        { }
        public Parttime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;
            partTimeCounter++;
        }

        public double GetPay()
        {
            double weeklypayment = Rate * Hours;
            return weeklypayment; 
        }
        public override string ToString()
        {
            return base.ToString() + $"\nRate: {this.Rate}\nHours: {this.Hours}";
        }
    }
}
