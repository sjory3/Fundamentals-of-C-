using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp3_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ex7();
            Console.ReadLine();
        }

        //Write an expression that checks whether an integer is odd or even.
        static void ex1()
        {
            int a = 4;

            if (a % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }

        /*Write a Boolean expression that checks whether a given integer is
        divisible by both 5 and 7, without a remainder.*/
        static void ex2()
        {
            int a = 70;

            if (a % 5 == 0 && a % 7 == 0)
            {
                Console.WriteLine("Is divisible by 5 and 7");
            }
            else
            {
                Console.WriteLine("is not divisible by 5 and 7");
            }
        }

        /*Write an expression that looks for a given integer if its third digit (right
        to left) is 7.*/
        static void ex3()
        {
            int a = 1700;
            int b = a / 100;
            int c = b % 10;

            if (c == 7)
            {
                Console.WriteLine("its 7");
            }
            else
            {
                Console.WriteLine("its not 7");
            }


        }

        /*Write an expression that checks whether the third bit in a given integer
        is 1 or 0.*/
        static void ex4()
        {
            int a = 7;
            bool bit3 = (a & 8) != 0;
            if (bit3)
            {
                Console.WriteLine("the third bit is 1");
            }
            else
            {
                Console.WriteLine("the third bit is 0");
            }
        }

        /*Write an expression that calculates the area of a trapezoid by given
        sides a, b and height h.*/
        static void ex5()
        {
            int a = 2;
            int b = 2;
            int h = 3;

            int result = ((a + b) / 2) * h;
            Console.WriteLine(result);
        }

        /*Write a program that prints on the console the perimeter and the area
        of a rectangle by given side and height entered by the user.*/
        static void ex6()
        {
            Console.WriteLine("Enter Side");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int b = int.Parse(Console.ReadLine());

            float area = a * b;
            float perimeter = (a * 2) + (b * 2);

            Console.WriteLine("Rectangle area = " + area);
            Console.WriteLine("Rectangle Perimeter  = " + perimeter);
        }

        /*The gravitational field of the Moon is approximately 17% of that on the
        Earth. Write a program that calculates the weight of a man on the
        moon by a given weight on the Earth.*/
        static void ex7()
        {
            Console.WriteLine("Enter your weight in kg");
            float weight = float.Parse(Console.ReadLine());

            float moonWeight = weight-(weight * 0.17f);

            Console.WriteLine("ya weight: " + moonWeight + "kg on the moon");
        }

        /*Write an expression that checks for a given point {x, y} if it is within
        the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of
        the circle and 5 is the radius.*/
        static void ex8()
        {

        }
    }
}
