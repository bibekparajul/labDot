using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    internal class Student: Person
    {
        //tala ko duiline base constructor example ho hai 
        public int StudentId { get; set; }
        public Student(string name, string email, string phone, int studentId) : base(name, email, phone)
        {
            StudentId = studentId;
        }


        ////yo muni ko DisplayInfo method hiding
        //public new  int DisplayInfo()
        //{
        //    return 1;

        //}


        //yo muni ko method overriding
        public  void Display()
        {
            Console.WriteLine("Student");
            base.DisplayInfo();
            

        }
    }
}
