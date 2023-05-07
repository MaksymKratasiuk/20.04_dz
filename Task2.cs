using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._04_dz
{


    internal class Task2
    {
        delegate void DisplayDelegate();

        public static void task2()
        {
            DisplayDelegate display = DisplayTime;
            display += DisplayDate;
            display += DisplayDayOfWeek;

            display();

            CalculateDelegate calculate = CalculateTriangleArea;
            calculate += CalculateRectangleArea;

            double baseLength = 5.0;
            double height = 3.0;
            double width = 4.0;
            double length = 6.0;

            calculate(baseLength, height);
            calculate(width, length);
        }

        static void DisplayTime()
        {
            Console.WriteLine("The current time is: " + DateTime.Now.ToLongTimeString());
        }

        static void DisplayDate()
        {
            Console.WriteLine("The current date is: " + DateTime.Now.ToShortDateString());
        }

        static void DisplayDayOfWeek()
        {
            Console.WriteLine("Today is: " + DateTime.Now.DayOfWeek.ToString());
        }

        delegate void CalculateDelegate(double length, double width);

        static void CalculateTriangleArea(double @base, double height)
        {
            double area = 0.5 * @base * height;
            Console.WriteLine("The area of the triangle is: " + area);
        }

        static void CalculateRectangleArea(double width, double length)
        {
            double area = width * length;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
