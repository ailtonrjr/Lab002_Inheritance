using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab002Inheritance
{
    public class Salaried : Employee
    {
        public double Salary { get; set; }
        public static double salariedCounter;

        public Salaried() 
        { }
        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary) : base(id, name, address, phone, sin, dob, dept)
        {
            this.Salary = salary;
            salariedCounter++;
        }
        public double GetPay()
        {
            double weeklypayment = this.Salary;
            return weeklypayment;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSalary: {this.Salary}";
        }
    }
}
