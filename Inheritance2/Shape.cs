using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{

    public abstract  class Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public abstract void Area();

        //public abstract void Perimeter();

    }
}
