using System;
using System.IO;
using System.Xml.Linq;

namespace Lab002Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee ("50", "Joe", "66 A St", "123-456-789", 23453452342, "01/03/1998", "Sales");

            //Employee emp2 = new Employee();

            //Console.WriteLine(emp1.ToString());
            //Console.WriteLine(emp2.ToString());

            //Salaried salaried1 = new Salaried("50", "Joe", "66 A St", "123-456-789", 23453452342, "01/03/1998", "Sales", 1900.00);

            //Console.WriteLine(salaried1.ToString());
            //Console.WriteLine(salaried1.GetPay());


            string [] txt_employee = File.ReadAllLines("C:\\Users\\ailto\\OneDrive\\Documentos\\Software Development\\CPRG-211 - Object-Oriented Programming 2\\Lab002Inheritance\\employees.txt");
            
            //creating lists that will receive the info [str lines] from txt file
            List<string> salariedList = new List<string>();
            List<string> wagedList = new List<string>();
            List<string> partTimeList = new List<string>();


            //split the file into the different types of emploeeys
            foreach (string line in txt_employee)
            {
                if (line[0] == '0' || line[0] == '1' || line[0] == '2' || line[0] == '3' || line[0] == '4')
                {salariedList.Add(line);}

                else if (line[0] == '5' || line[0] == '6' || line[0] == '7')
                {wagedList.Add(line);}

                else {partTimeList.Add(line);}

            }
            
            //building a list of objects of the class Salaried
            List<Salaried> salarieds = new List<Salaried>();   

            //Console.WriteLine("Salaried:");
            foreach (string line in salariedList)
            { 
                string[] salLineSplit = line.Split(':');
                //necessary to convert index 4 in long and index 7 in double
                long newSalLineSplitLong = long.Parse(salLineSplit[4].Trim());
                double newSalLineSplitDouble = double.Parse(salLineSplit[7].Trim());

                string id = salLineSplit[0].Trim();
                string name = salLineSplit[1].Trim();
                string address = salLineSplit[2].Trim();
                string phone = salLineSplit[3].Trim();
                long sin = newSalLineSplitLong;
                string dob = salLineSplit[5].Trim();
                string dept = salLineSplit[6].Trim();
                double salary = newSalLineSplitDouble;

                //building the objects of the class Salaried using the txt file info
                Salaried salaried = new Salaried(id, name, address, phone, sin, dob, dept, salary);

                //adding the new objects to the list of objects
                salarieds.Add(salaried);
            }
            //confirming wheter all objects were created and put into the list
            //foreach (var salaried in salarieds)
            //{
            //    Console.WriteLine("This is part of ToString:\n" + salaried.ToString());
            //}


            //building a list of objects of the class Wages
            List<Wages> wages = new List<Wages>();

            //Console.WriteLine("Waged: ");
            foreach(string line in wagedList)
            {
                string[] wagLineSplit = line.Split(':');
                //necessary to convert index the index 4 in long and index 7 and 8 in double
                long newWagLineSplitLong = long.Parse(wagLineSplit[4].Trim());
                double newWagLineSplitDoubleRate = double.Parse(wagLineSplit[7].Trim());
                double newWagLineSplitDoubleHours = double.Parse(wagLineSplit[8].Trim());

                string id = wagLineSplit[0].Trim();
                string name = wagLineSplit[1].Trim();
                string address = wagLineSplit[2].Trim();
                string phone = wagLineSplit[3].Trim();
                long sin = newWagLineSplitLong;
                string dob = wagLineSplit[5].Trim();
                string dept = wagLineSplit[6].Trim();
                double rate = newWagLineSplitDoubleRate;
                double hours = newWagLineSplitDoubleHours;

                //building the objects of the class Wages using the txt file info
                Wages waged = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);

                //adding the new objects to the list of objects
                wages.Add(waged);
            }
            //confirming wheter all objects were created and put into the list
            //foreach (var waged in wages)
            //{
            //    Console.WriteLine("This is part of ToString:\n" + waged.ToString());
            //}


            //building a list of objects of the class Part Time
            List<Parttime> partTimes = new List<Parttime>();

            //Console.WriteLine("Part Time:");
            foreach (string line in partTimeList) 
            {
                string[] ptLineSplit = line.Trim().Split(':');
                //necessary to convert index the index 4 in long and index 7 and 8 in double
                long newPtLineSplitLong = long.Parse(ptLineSplit[4].Trim());
                double newPtLineSplitDoubleRate = double.Parse(ptLineSplit[7].Trim());
                double newPtLineSplitDoubleHours = double.Parse(ptLineSplit[8].Trim());

                string id = ptLineSplit[0].Trim();
                string name = ptLineSplit[1].Trim();
                string address = ptLineSplit[2].Trim();
                string phone = ptLineSplit[3].Trim();
                long sin = newPtLineSplitLong;
                string dob = ptLineSplit[5].Trim();
                string dept = ptLineSplit[6].Trim();
                double rate = newPtLineSplitDoubleRate;
                double hours = newPtLineSplitDoubleHours;

                //building the objects of the class Part Time using the txt file info
                Parttime parttimeempl = new Parttime(id, name, address, phone, sin, dob, dept, rate, hours);

                //adding the new objects to the list of objects
                partTimes.Add(parttimeempl);
            }
            //confirming wheter all objects were created and put into the list
            //foreach (var parttimeemployee in partTimes)
            //{
            //    Console.WriteLine("This is part of ToString:\n" + parttimeemployee.ToString());
            //}

            //PAYMENT WORKFLOW

            //Calculate and return the average weekly pay for all employees. 
            Console.WriteLine("\nPayments for Salaried:\n");
            double totalpaymentsalaried = 0;
            foreach (var salaried in salarieds) 
            {
                Console.WriteLine($"{salaried.Name}'s weekly pay is: {salaried.GetPay()}\n");
                totalpaymentsalaried += salaried.GetPay();
            }
            Console.WriteLine($"\nTotal amount paid for salarieds was: ${totalpaymentsalaried}\n");

            Console.WriteLine("\nPayments for wages:\n");
            double totalpaymentwaged = 0;
            foreach (var waged in wages)
            {
                Console.WriteLine($"{waged.Name}'s weekly pay is: {waged.GetPay()}\n");
                totalpaymentwaged += waged.GetPay();
            }
            Console.WriteLine($"\nTotal amount paid for wageds was: ${totalpaymentwaged}\n");


            Console.WriteLine("\nPayments for Part Time:\n");
            double totalpaymentparttime = 0;
            foreach (var parttimeemployee in partTimes)
            {
                Console.WriteLine($"{parttimeemployee.Name}'s weekly pay is: ${parttimeemployee.GetPay()} \n");
                totalpaymentparttime += parttimeemployee.GetPay();
            }
            Console.WriteLine($"\nTotal amount paid for part time was: ${totalpaymentparttime}\n");

            double globalamount = totalpaymentsalaried + totalpaymentwaged + totalpaymentparttime;
            Console.WriteLine($"\nThe global amount paid in salaries was ${globalamount}\n");

            //Calculate and return the highest weekly pay for the wage employees,including the name of the employee.
            //Ordering the list of objects of the class Wages by the wages.GetPay [weekly payment] from the highest to the lowest
            List<Wages> maxWageSalary = wages.OrderByDescending(waged => waged.GetPay()).ToList();
            Console.WriteLine($"{maxWageSalary[0].Name} has the highest weekkly pay among the wage employees, receiving ${maxWageSalary[0].GetPay()}\n");

            //Calculate and return the lowest salary for the salaried employees,
            //including the name of the employee
            //Ordering the list of objects of the class Part Time by the parttime.GetPay [weekly payment] from the lowest to the highest
            List<Parttime> minPtSalary = partTimes.OrderBy(parttimeemployee => parttimeemployee.GetPay()).ToList();
            Console.WriteLine($"{minPtSalary[0].Name} has the lowest weekly pay among the part-time employees, receiving ${minPtSalary[0].GetPay()}\n");

            //COUNTERS STUFF
            Console.WriteLine($"\nThe total number of employees is: {Employee.employeeCounter}\n");

            double salariedPerc = Math.Round((Salaried.salariedCounter / Employee.employeeCounter) * 100);
            double wagesPerc = Math.Round((Wages.wagesCounter / Employee.employeeCounter) * 100);
            double partTimePerc = Math.Round((Parttime.partTimeCounter / Employee.employeeCounter) * 100);

            Console.WriteLine($"\nSalaried represents {salariedPerc}% of the total of employees.\n");
            Console.WriteLine($"\nWages represents {wagesPerc}% of the total of employees.\n");
            Console.WriteLine($"\nPart time represents {partTimePerc}% of the total of employees.\n");

        }
    }
}
