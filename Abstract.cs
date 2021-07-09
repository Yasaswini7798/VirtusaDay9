using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    abstract class Assesment
    {
        public int m1, m2;
        public Assesment()
        {
            Console.WriteLine("enter m1 and m2:");
            m1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
        }
        public static void fun1()
        {
            Console.WriteLine("hi iam static");
        }
        public abstract void caltotal();
    }
    abstract class Implement1 : Assesment
    {
        public Implement1()
        {
            Console.WriteLine("Iam in implementation1");
        }
    }
    class Implement2 : Implement1
    {
        public int total;
        public override void caltotal()
        {
            total = m1 + m2;
            Console.WriteLine("Total=" + total);
        }
    }

    class Abstract
    {
        static void Main(string[] args)
        {
            Assesment ob = new Implement2();
            ob.caltotal();
            Assesment.fun1();



        }
    }
}