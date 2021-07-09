using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class Shape
    {
        public int len, bred, rad;
        public void getlen()
        {
            Console.WriteLine("Enter the length");
            len = int.Parse(Console.ReadLine());
        }
        public void getbreadth()
        {
            Console.WriteLine("Enter the breadth");
            bred = int.Parse(Console.ReadLine());
        }
        public void getradius()
        {
            Console.WriteLine("Enter the radius");
            rad = int.Parse(Console.ReadLine());
        }

    }
}

