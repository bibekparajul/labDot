using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppCsit
{
    internal class Time
    {
        public decimal Seconds { get; set; } 


        public Time()
        {
            Seconds = 0;
        }
        public Time(decimal seconds)
        {
            Seconds = seconds;
        }

        public void Test()
        {
            //int where = 1; //contextual keyword(context anusar aafai diney)-> for backward compactibility
            //int from = 2;
            int[] arr = new int[] { 1,2,3,4,5};


            var b  = from a in arr
                     where a>2
                     select a;
            Console.WriteLine(b);
            
        }

    }
}

