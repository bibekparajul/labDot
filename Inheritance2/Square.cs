using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class  Square : Shape
    {
        public override void  Area()
        {
           int area = Length * Length;

            Console.WriteLine($"the area is when {Length} is:" + area);
        }

        
    }
}
