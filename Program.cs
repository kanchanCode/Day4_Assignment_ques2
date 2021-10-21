using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment2
{
    public class UC1
    { 
    public double x1, y1, x2, y2;
    
        public UC1(double x1,double y1,double x2,double y2)
    {
            this.x1=x1;
            this.y1=y1;
            this.x2=x2;
            this.y2=y2;
    }
        public double compute()
        {
        double x = 0;
        double y = 0;
        double a = 0;
        double b = 0;
        double length = 0;

           //Console.WriteLine("Enter value for x1");
            //x1 = Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("Enter value for y1");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter value for x2");
           // x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter value for y2");
           // y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("First point (" + x1 + "," + y1 + ")");
            Console.WriteLine("Second point (" + x2 + "," + y2 + ")");

            x = x2 - x1;
            y = y2 - y1;

            a = Math.Pow(x, 2);
            b = Math.Pow(y, 2);

            length = Math.Sqrt(a + b);

            Console.WriteLine("Length of the line is " + length);

            return length;

           

        }
    }
}
