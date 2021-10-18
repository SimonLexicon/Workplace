using System;
using System.Collections.Generic;
using Workplace.Models;

namespace Workplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            Person person0 = new Person("Kalle", "+46123456", "Skövde, bogatan 5");

            Customer customer0 = new Customer("Gustav", "+4613579", "Bogata 10", "Hamngatan10");

            Employee employee0 = new Employee("per sonn",
                "+46123456",
                "Skövde, bogatan 5",
                10000,
                "IT");
       
            employee0.AddTask("Bring Coffe");
            employee0.AddTask("Write Feature");

            Employee[] empList = new Employee[] {employee0 };

            Administrator admin0 = new Administrator("Olof",
                                                    "+46987654",
                                                    "Skövde, bogatan 5",
                                                    20000,
                                                    "IT - admin",
                                                    empList,
                                                    999);
            admin0.AddTask("Administrate Employee list");


            //foreach (string task in admin0.TasksToDo())
            //{
            //    Console.WriteLine("Work with: " + task);
            //}
            List<Person> listOfPersons = new List<Person>() {person0, customer0, employee0, admin0 };

            //foreach (Person per in listOfPersons)
            //{
            //    Console.WriteLine(per.Name);
            //    if (per is Administrator)
            //    {
            //        Console.WriteLine((per as Administrator).Info());
            //    }
            //    else if (per is Customer)
            //    {
            //        Console.WriteLine((per as Customer).Info());
            //    }
            //    else if (per is Employee)
            //    {
            //        Console.WriteLine((per as Employee).Info());
            //    }
            //    else if (per is Person)
            //    {
            //        Console.WriteLine((per as Person).Info());
            //    }


            //    Console.WriteLine("\n");
            //}




            foreach (Person worker in listOfPersons)
            {
                Console.WriteLine("\n" + worker.Name);
                if(worker is Employee)
                { 
                    foreach (string work in (worker as Employee).TasksToDo())
                    {
                        Console.WriteLine(work);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
