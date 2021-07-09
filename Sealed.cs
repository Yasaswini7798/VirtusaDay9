using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class Sample
    {
        public int x;
        public Sample(int a)
        {
            x = a;
        }
        public void display()
        {
            Console.WriteLine("X=" + x);
        }
        public virtual void message()
        {
            Console.WriteLine("Sample class");
        }
    }
    class Sample2 : Sample
    {
        public int y;
       public Sample2(int a,int b):base(a)
        {
            y = b;
            Console.WriteLine("hey iam here & y="+y);
        }
        public  override void message()
        {
            Console.WriteLine("Sample2 class");
        }

    }
    class Sample3 : Sample2
    {
        public int z;
        public Sample3(int a,int b,int c) : base(a,b)
        {
            z = c;
            Console.WriteLine("hey iam here & z="+z);
        }
        public sealed override void message()
        {
            Console.WriteLine("Sample3 class");
        }

    }
    class Sample4 : Sample3
    {
        readonly int myvar = 77;
        public Sample4(int a, int b, int c) : base(a, b,c)
        {
            myvar++;
            Console.WriteLine("myvar=" + myvar);
            
        }
        public void message()
        {
            Console.WriteLine("myvar=" + myvar);
            Console.WriteLine("Sample4 class");
        }

    }
    class Sealed
    {
        static void Main(String[] args)
        {
            Sample ob = new Sample4(33, 4, 5);
            ob.message();

        }
    }
}
