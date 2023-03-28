using System;

namespace Indexer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyCollection c = new MyCollection();

            //c[1] = "Class one";
            //c[2] = "Class two";
            //c[3] = "Class three";

            //c[6] = "Class six";
            //Console.WriteLine("Index 1: " + c[1]);
            //Console.WriteLine("Index 2: " + c[2]);
            //Console.WriteLine("Index 3: " + c[3]);
            //Console.WriteLine("Index 6: " + c[6]);


            MyList l = new MyList(5);
            l[0] = 11;
            l[1] = 33;
            l[4] = 55;
           

            Console.WriteLine("Index0:" + l[0]);
            Console.WriteLine("Index1:" + l[1]);
            Console.WriteLine("Index4:" + l[4]);
           
            
        }
    }
}