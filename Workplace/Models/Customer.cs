using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models
{
    class Customer : Person
    {
        string[] purchaseHistory;
        string DeliveryAdress { get; set; }
        public Customer(string name, string phone,
                string adress, string deliveryAdress )
                : base(name, phone, adress)
        {
            DeliveryAdress = deliveryAdress;
            this.purchaseHistory = new string[0];
        }
        public new string Info()
        {
            return base.Info() + $"\n Delivery Adress: {DeliveryAdress}";
        }
    }
}
