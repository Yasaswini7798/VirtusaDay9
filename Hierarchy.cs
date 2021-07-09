using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    
        class Square : Shape
        {
            public int area, peri;
            public void calculate()
            {
                getlen();
                area = len * len;
                peri = 4 * len;
            }
        public void display()
        {
            Console.WriteLine("Length:" + len);
            Console.WriteLine("Area:" + area);
            Console.WriteLine("Perimeter:" + peri);
        }
        }
    class Circle : Shape
    {
        public double area, circumference;
       
        
        public void calculate()
        {
            getradius();
           
            area = 3.142 * rad * rad;
            circumference = 2 * (3.142 * rad);
        }
            public void display()
            {
               
                Console.WriteLine("Area:" + area);
                Console.WriteLine("Circumference:" + circumference);
            }

        }
        class Hierarchy
        {
             static void Main(string[] args)
            {
                Square sq = new Square();
                sq.calculate();
           
                sq.display();
            Circle c = new Circle();
                c.calculate();
                c.display();
              
            }
        }
    }

