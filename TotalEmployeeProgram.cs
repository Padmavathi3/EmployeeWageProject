using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProject
{
    class Employee
    {
        public static List<Employee> listobj = new List<Employee>();
        public string Id { get; set; }    //Assigning the values
        public string Name { get; set; }
        public string Type { get; set; }
        public string attendence { get; set; }


        public void AddNewEmployee()              //creating new contact
        {
             Employee a = new Employee();      // create object to store the contact details
               
            Console.WriteLine("enter the Id of employee:");
            a.Id = Console.ReadLine().ToLower();
            Console.WriteLine("enter the Name of employee:");
            a.Name = Console.ReadLine().ToLower();
            Console.WriteLine("enter the type of employee:");
            a.Type = Console.ReadLine().ToLower();
            Console.WriteLine("enter whether the employee is present or absent:");
            a.attendence = Console.ReadLine().ToLower();


            listobj.Add(a);   // add storing details( in a) to list

            Console.WriteLine("do you want check another option:");
            string op = Console.ReadLine();
            if (op.ToLower() == "yes")
            {
                MainClass.Main(new string[] { });


            }

        }
        public void CheckStatus()
        {
            Console.WriteLine("enter the employee id to check the status:");
            string x= Console.ReadLine();
            foreach(Employee e in listobj) 
            {
                if(x.Equals(e.Id))
                {
                   int index=listobj.IndexOf(e);
                    Console.WriteLine($"the employee is {listobj[index].attendence}");
                    
                }
                else if((x.Equals(e.Id))==false)
                {
                    Console.WriteLine("searching employee was not matched with anyone");
                }
            }
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainClass.Main(new string[] { });


            }
        }
        public void DailyWage()
        {

            int part_h = 4, full_h = 8,amount_h=20;
            Console.WriteLine("enter the employee id to check the status:");
            string x = Console.ReadLine();
            foreach (Employee e in listobj)
            {
                if (x.Equals(e.Id))
                {
                    int index = listobj.IndexOf(e);
                    if ((listobj[index].Type) == "part time")
                    {
                        int p_amount = part_h * amount_h;
                        Console.WriteLine("employee daily wage" + p_amount);
                    }
                    else if ((listobj[index].Type) == "full time")
                    {
                        int f_amount = part_h * amount_h;
                        Console.WriteLine("employee daily wage" + f_amount);
                    }
                    else
                    {
                        Console.WriteLine("employee type is not valid");
                    }
                }
                else if (x.Equals(e.Id)==false)
                {
                    Console.WriteLine("searching employee was not matched with anyone");
                }
            }
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainClass.Main(new string[] { });


            }
        }
        public void MonthlyWage()
        {
            Console.WriteLine("enter the employee id to check the status:");
            string x = Console.ReadLine();
            foreach (Employee e in listobj)
            {
                if (x.Equals(e.Id))
                {
                    Console.WriteLine("enter the days that how many days he did the work");
                    int d = int.Parse(Console.ReadLine());
                    int p_worked_h = d * 4;
                    int f_worked_h = d * 8;
                    int index = listobj.IndexOf(e);
                    if ((listobj[index].Type) == "part time")
                    {
                        if ((d == 20) || (p_worked_h == 100))
                        {
                            int p_amount1 = p_worked_h * 20;
                            Console.WriteLine("employee daily wage" + p_amount1);

                        }

                    }
                    else if ((listobj[index].Type) == "full time")
                    {
                        if ((d == 20) || (p_worked_h == 100))
                        {
                            int f_amount1 = f_worked_h * 20;
                            Console.WriteLine("employee daily wage" + f_amount1);

                        }
                    }


                }
            }    
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainClass.Main(new string[] { });


            }

        }
        public void EmployeeDetails()
        {
            if (listobj.Count > 0)
            {

                foreach (Employee a in listobj)
                {
                    Console.WriteLine("Person Id: " + a.Id);
                    Console.WriteLine("Person Name: " + a.Name);
                    Console.WriteLine("Person Type: " + a.Type);
                    Console.WriteLine(" ");

                }
            }
            else
            {
                Console.WriteLine("No one employee is there");
            }
            Console.WriteLine("do you want check another option:");
            string op1 = Console.ReadLine();
            if (op1.ToLower() == "yes")
            {
                MainClass.Main(new string[] { });


            }
        }


    }

    class MainClass
    {
        //public static List<AddressBook> listobj=new List<AddressBook>();
        public static void Main(string[] args)
        {
            Employee obj = new Employee();
            Console.WriteLine("choose any one option");
            Console.WriteLine("1.Add new Employee \n2.check status \n3.calculate daily wage\n4.calculate month wage\n5. employee details");
            Console.WriteLine("enter the option number:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.AddNewEmployee();
                    break;
                case 2:
                    obj.CheckStatus();
                    break;
                case 3:
                    obj.DailyWage();
                    break;
                case 4:
                    obj.MonthlyWage();
                    break;
                case 5:
                    obj.EmployeeDetails();
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
