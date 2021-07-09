using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class Addition
    {
        public void sum(int a,int b)
        {
            Console.WriteLine("(int,int)SUM=" + (a + b));
        }
        public void sum(int a, int b,int c)
        {
            Console.WriteLine("(int,int,int)SUM=" + (a + b+c));
        }
        public void sum(float a, float b)
        {
            Console.WriteLine("(float,float)SUM=" + (a + b));
        }
    }
    class OverLoading
    {
        static void Main(string[] args)
        {
            Addition ob = new Addition();
            ob.sum(33, 5);
            ob.sum(5, 7, 8);
            ob.sum(5.3f, 7.8f);
            ob.sum(5f, 7f);
            ob.sum(5.7f, 8);
        }
    }
}
