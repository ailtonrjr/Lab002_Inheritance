using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002Inheritance
{
    public class Wages : Employee
    {
        public double Rate { get; set; }
        public double Hours { get; set; }
        public static double wagesCounter;

        public Wages()
        { }
        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Rate = rate;
            this.Hours = hours;
            wagesCounter++;
        }

        public double GetPay()
        {
            double weeklypayment = 0;

            if (Hours > 40)
            {
                double overtime = Hours - 40;
                double payment1 = Rate * 40;
                double payment2 = (Rate * 1.5) * overtime;
                weeklypayment = payment1 + payment2;
            }
            else
            {
                weeklypayment = Rate * Hours;
            }

            return weeklypayment; 
        }

        public override string ToString()
        {
            return base.ToString() + $"\nRate: {this.Rate}\nHours: {this.Hours}";
        }
    }
}
