
using System;

namespace Loop
{
    public class Program
    {
        public static void Main()
        {

            //            Console.WriteLine("enter the number of lines: ");
            //            var n = Console.ReadLine();
            //            int line = int.Parse(n);


            //            //for (int i = 0; i < line; i++)
            //            //{
            //            //    for (int j = 0; j <= line - 1; j++)
            //            //    {
            //            //        Console.Write(' ');
            //            //    }
            //            //    for(int k = 0; k <= i; k++)
            //            //    {
            //            //        Console.Write("*");
            //            //    }
            //            //    Console.WriteLine();

            //            //}

            //            //whilw loop
            //            int a = 0;

            //            while (a < line)
            //            {
            //                int b = 0;
            //                while (b <= line - 1)
            //                {
            //                    Console.Write(' ');
            //                    b++;

            //                }
            //                int c = 0;
            //                while (c <= a)
            //                {
            //                    Console.Write("*");
            //                    c++;
            //                }
            //                Console.WriteLine();
            //                a++;
            //            }


            //loop foreach

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //foreach(int value in arr)
            //{
            //    Console.WriteLine(value);
            //}


            int a = 10;
            Users U = new Users { Id = 5, Name = "John" };
            Modify(a);
            Modify(U);

            Console.WriteLine(a);
            Console.WriteLine(U.Id);
            Console.WriteLine(U.Name);


        }
        public static void Modify(int n)
        {
            n = 100;
        }
        public static void Modify(Users user)
        {
            user.Id = 20;
            user.Name = "Bibek";
        }
    }


        public class Users
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
