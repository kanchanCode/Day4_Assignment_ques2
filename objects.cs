using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment2
{
    class Program

    {
     static void Main(string[] args)
        {

            //User case 1
            UC1 Line1 = new UC1(3, 4, 7,8);
            double j=Line1.compute();
            UC1 Line2 = new UC1(30, 4, 17, 8);
            double k = Line2.compute();

            //UserCase 2
            if (j == k)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }

            //UserCase 3
            if (j>k)
            {
                Console.WriteLine("Length of Line 1 is greater than Line 2");
            }
            else if (j<k)
            {
                Console.WriteLine("Length of Line 1 is smaller than Line 2");

            }
        }
       
    
    }
}
