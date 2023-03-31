
using DemoAppCsit.Part;
using System;
namespace DemoAppCsit {
    public class Program
    {
        public static void Main(string[] args)
        {

            //try
            //{
            //    int a = 1;
            //    int b = 0;
            //    if (b == 0)
            //    {
            //        throw new Exception("Cannot divide by 0");
            //    }
            //    int c = a / b;
            //    Console.WriteLine("Completed Try Block");

            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch
            //{
            //    Console.WriteLine("Generic exception block");
            //}
            //finally
            //{
            //    Console.WriteLine("this is finally block");
            //}
            DisplayInfo(2,"Bbek","Nepali");        //positional args

            DisplayInfo(name: "Dyan", age: 22, nationality: "USA"); //named ards

            //optional args if muni ko mai default value dini ...
        
        }

        public static void DisplayInfo(int age , string name, string nationality)  //string nationality = "Nepal"
        {
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Nationality:" + nationality);
        }
    }


}
