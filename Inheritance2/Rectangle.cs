using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Rectangle : Shape
    {


        public override void Area()
        {
            int area = Length * Breadth;
            Console.WriteLine("the area is:"+area);
        }        
        
        public void Perimeter()
        {

            int per = 2*(Length + Breadth);
            Console.WriteLine("the perimater is: "+per);
        }
    }
}
