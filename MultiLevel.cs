using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtusaDay9
{
    class Student
    {
        public string name;
        public int roll, classno;

        public Student()
        {
            Console.WriteLine("Enter roll,Classnum & Name:");
            roll = int.Parse(Console.ReadLine());
            classno = int.Parse(Console.ReadLine());
            name = Console.ReadLine();

        }
        public Student(int r, int c, string n)
        {
            roll = r;
            classno = c;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("ROLL:" + roll);
            Console.WriteLine("NAME:" + name);
            Console.WriteLine("CLASSNUM:" + classno);
        }
    }
    class MarksDetails : Student
    {
        public int noofsub, tot;
        public int[] marks;
        public MarksDetails()
        {
            Console.WriteLine("enter the no of subjects");
            noofsub = int.Parse(Console.ReadLine());
            marks = new int[noofsub];
            Console.WriteLine("enter the marks");
            for (int i = 0; i < noofsub; i++)
                marks[i] = int.Parse(Console.ReadLine());
            tot = 0;
        }
        public void calculate()
        {
            for (int i = 0; i < noofsub; i++)
                tot += marks[i];
        }
        public void marksdisplay()
        {
            base.display();
            Console.WriteLine("No of Subjects" + noofsub);
            for (int i = 0; i < noofsub; i++)
            {
                Console.WriteLine("Marks{0}:    {1}", i + 1, marks[i]);
            }
            Console.WriteLine("Total:" + tot);
            Console.WriteLine();
        }
    }
    class ReportCard : MarksDetails
    {
         int avg;
        public string grade;
        public void calc()
        {
            base.calculate();
            avg = tot / noofsub;
            if (avg >= 35)
                grade = "pass";
            else
                grade = "fail";
        }
        public void disp()
        {
            base.display();
            Console.WriteLine("the average is:" + avg);
            Console.WriteLine("the grade is:" + grade);
        }
    }
    class MultiLevel
    {

        static void Main(String[] args)
        {
            ReportCard ob = new ReportCard ();
            ob.calc();
            ob.disp();
        }

    }
}