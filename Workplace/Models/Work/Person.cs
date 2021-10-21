using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Work
{
    public class Person : IInformation
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ContactAdress { get; set; } 
        

        public Person(string name, string phone, string adress)
        {
            Name = name;
            Phone = phone;
            ContactAdress = adress;
        }

        public string Info()
        {
            return $"{IInformation.INFOTEXT}\n {Name}\n {Phone}\n{ContactAdress}";
        }

    }
}
