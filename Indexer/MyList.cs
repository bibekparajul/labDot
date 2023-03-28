using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class MyList<T>
    {
        private T[] _arr;

        public MyList(int size)
        {
            _arr = new T[size];
        }
        public T this[int idx]
        {
            get
            {
                //if (idx > _arr.Length)
                //{
                //    Console.WriteLine("Invalid Index");
                //    return -1;
                //}
                
                return _arr[idx];
            }
            set
            {
                _arr[idx] = value;
            }
        }
    }
}
