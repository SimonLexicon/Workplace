using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Work
{
    // Employee = child,  Person = parent
    class Employee : Person
    {
        protected string[] tasks;
        int salery; 
        public int Salery { get { return salery; } set { salery = value; } }
        public string Department { get; set; }

        public Employee(string name, string phone,
                        string adress, int salery,
                        string department)
            : base(name, phone, adress)
        {
            Salery = salery;
            Department = department;
            this.tasks = new string[0];
        }

        public new string Info()
        {
            return base.Info() + $"\nSalery: {Salery}";
        }

        public virtual string[] TasksToDo()
        {
            return tasks;
        }

        public void AddTask(string newTask)
        {
            Array.Resize(ref tasks, tasks.Length + 1);
            tasks[tasks.Length - 1] = newTask;
        }

    }
}
