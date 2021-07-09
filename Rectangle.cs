using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class Rectangle:Shape
    {
        public int area, peri;
        public void calculate()
        {
            getlen();
            getbreadth();
            area = len * bred;
            peri = 2 * (len + bred);
        }
        public void display()
        {
            Console.WriteLine("Length:" + len);
            Console.WriteLine("Breadth:" + bred);
            Console.WriteLine("Area:" + area);
            Console.WriteLine("Perimeter:" + peri);
        }
    }
}
