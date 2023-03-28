using System;

namespace Inheritance
{
    public class Program
    {
        public static void Main()
        {
            Rectangle r = new Rectangle();
            r.rArea();
            //r.rPerimeter();
            Square s = new Square();
            s.sArea();

        }
    }

    public class Shape
    {
        public string Length { get; set; }
    public string Breadth  {get; set; }

    }

    public class Rectangle: Shape
    {

        public void rArea()
        {
            Console.WriteLine("Enter the length:");
            var Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            var Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine(Length * Breadth);
            //int area = Length * Breadth;
        }

        public void rPerimeter()
        {
            Console.WriteLine("the perimeter is: ");
            Console.WriteLine("Enter the length:");
            var Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            var Breadth = int.Parse(Console.ReadLine());
            Console.WriteLine(2*(Length+Breadth));



        }
    }
    public class Square: Shape
    {
        public void sArea()
        {
            Console.WriteLine("Enter the Length for square area:");
            var Length = int.Parse(Console.ReadLine());

            Console.WriteLine(Length * Length);
        }
    }

    
}