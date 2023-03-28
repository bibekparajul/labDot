using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    
     public class Person
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Person(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }   

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Phone:" + Phone);
        }
    }
}