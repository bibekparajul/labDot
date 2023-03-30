
using DemoAppCsit.Part;
using System;
namespace DemoAppCsit {
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                int a = 1;
                int b = 0;
                if (b == 0)
                {
                    throw new Exception("Cannot divide by 0");
                }
                int c = a / b;
                Console.WriteLine("Completed Try Block");

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("Generic exception block");
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }


        }
    }


}
