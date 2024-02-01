using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab002Inheritance
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public long Sin {  get; set; }
        public string Dob { get; set; }
        public string Dept {  get; set; }
        public static double employeeCounter;

        //private string name; //variable to getter and setter

        ////Getter
        //public string GetName()
        //{
        //    return name;
        //} 

        ////Setter
        //public void SetName(string newName)
        //{
        //    this.Name = newName;
        //}





        //
      
       
        public Employee ()
        { } //Default Constructor

        public Employee (string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            //Concrete constructor
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
            employeeCounter++;
        }

        //***using the getter and setter***
        //public int Age //this is a property
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        public override string ToString()
        {
            return $"Employee's Info\nId: {this.Id}\nName: {this.Name}\nAddress: {this.Address}\nPhone: {this.Phone}\nSin: {this.Sin}\nDOB: {this.Dob}\nDepartment: {this.Dept}";
        }

    }
}
