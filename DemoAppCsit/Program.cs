
using System;
namespace DemoAppCsit {
    public class Program
    {
        public static void Main()
        {


            Console.WriteLine("enter the number of lines: ");
            var n = Console.ReadLine();
            int line = int.Parse(n);


            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j <= line - 1; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }



        }
    }


}
