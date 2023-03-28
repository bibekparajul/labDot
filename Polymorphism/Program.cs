using Polymorphism.MethodOverloading;
using Polymorphism.OperatorOverloading;
using System;

namespace Polymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int resultInt = Operation.Add(1, 2);
            //resultInt = Operation.Add(2, 3,5);

            //decimal resultDecimal = Operation.Add(3.1m, 4.0m,5.8m);
            // resultDecimal = Operation.Add(3.1m, 4.0m);


            Rectangle R1 = new Rectangle
            {
                Length = 10,
                Breadth = 5
            };
            Rectangle R2 = new Rectangle
            {
                Length = 4,
                Breadth = 4
            };
            Rectangle R3 = R1 + R2;
            Console.WriteLine(R3.Length);
        }
    }
}