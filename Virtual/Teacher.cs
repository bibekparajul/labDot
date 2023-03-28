using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    internal class Teacher: Person
    {
        public Teacher(string name, string email, string phone) : base(name, email, phone)
        {
        }

        public  void Display()
        {
            Console.WriteLine("Teacher");
                base.DisplayInfo();

        }
    }
}
