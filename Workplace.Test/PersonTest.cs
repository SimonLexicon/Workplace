using System;
using Xunit;
using Workplace.Models.Work;

namespace Workplace.Test
{
    public class PersonTest
    {
        [Fact]
        public void PersonConstructor()
        {
            string name = "Per";
            string phone = "123456";
            string adress = "bogatan";
            Person person0 = new Person(name, phone, adress);

            Assert.Equal(person0.Name, name);
            Assert.Equal(person0.Phone, phone);
            Assert.Equal(person0.ContactAdress, adress);
        }

        [Fact]
        public void PersonInfo()
        {
            string name = "Per";
            string phone = "123456";
            string adress = "bogatan";
            Person person0 = new Person(name, phone, adress);

            string result = person0.Info();

            Assert.Equal("Information:\n Per\n 123456\nbogatan", result);
        }
    }
}
