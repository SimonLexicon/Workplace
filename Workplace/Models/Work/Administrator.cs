using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Work
{
    // Administrator = child, Employee = parent
    class Administrator : Employee
    {
        Employee[] employeesList;
        public int Bonus { get; set; }
        public Administrator(string name,
                            string phone,
                            string adress,
                            int salery,
                            string department,
                            Employee[] employees,
                            int bonus)
            :base(name, phone, adress, salery, department)
        {
            this.employeesList = employees;
            Bonus = bonus;
        }

        public new string Info()
        {
            return base.Info() + $"\nBonus: {Bonus}";
        }
        public override string[] TasksToDo()
        {
            string[] tasksToReturn = new string[tasks.Length];
            tasks.CopyTo(tasksToReturn, 0);
            Array.Resize(ref tasksToReturn, employeesList.Length + tasksToReturn.Length);

            int index = tasks.Length;
            foreach(Employee employee in employeesList)
            {
                tasksToReturn[index] = "Employee: " + employee.Name;
                index++;
            }
            return tasksToReturn; 
        }
    }
}
