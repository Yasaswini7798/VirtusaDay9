using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class A
    {
        public int x, y;
        public A(int a,int b)
        {
            x = a;
            y = b;
        }
    }
    class B : A
    {
        public int m, n;
        public B(int a,int b,int c,int d):base(c,d)
        {
            m = a;
            n = b;
        }
        public void display()
        {
            Console.WriteLine("x={0} y={1} m={2} n={3}", x, y, m, n);
        }
    }
    class ExampleConstr
    {
        static void Main(String[] args)
        {
            B ob = new B(11,2,1,3);
            ob.display();
        }
    }
}
