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
            ex10();
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

            float moonWeight = weight - (weight * 0.17f);

            Console.WriteLine("ya weight: " + moonWeight + "kg on the moon");
        }

        /*Write an expression that checks for a given point {x, y} if it is within
        the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of
        the circle and 5 is the radius.*/
        static void ex8()
        {
            int[] cords = { 0, 0 };
            Console.WriteLine("Enter X");
            cords[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            cords[1] = int.Parse(Console.ReadLine());

            int radius = 5;

            bool isInSide = (cords[0] * cords[0]) + (cords[1] * cords[1]) <= (radius * radius);

            if (isInSide)
            {
                Console.WriteLine("The point is in side the cirkle");
            }
            else
            {
                Console.WriteLine("the point is not inside");
            }

        }

        /*Write an expression that checks for given point {x, y} if it is within the
        circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}].
        Clarification: for the rectangle the lower left and the upper right corners
        are given*/
        static void ex9()
        {
            int[] cords = { 0, 0 };
            Console.WriteLine("Enter X");
            cords[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            cords[1] = int.Parse(Console.ReadLine());

            int radius = 5;

            bool isInSide = (cords[0] * cords[0]) + (cords[1] * cords[1]) <= (radius * radius);

            if (isInSide && (cords[0] <= 5 && cords[0] >= -1) && (cords[1] <= 5 && cords[1] >= 1))
            {
                Console.WriteLine("The point is in side the cirkle and rectangle");
            }
            else if (isInSide)
            {
                Console.WriteLine("the point is inside the cirkle but not the rectangle");
            }
            else if ((cords[0] <= 5 && cords[0] >= -1) && (cords[1] <= 5 && cords[1] >= 1))
            {
                Console.WriteLine("the point is inside the rectangle but not the cirkle");
            }
            else
            {
                Console.WriteLine("the point is not inside");
            }
        }

        /*Write a program that takes as input a four-digit number in format abcd
        (e.g. 2011) and performs the following actions:
        - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        - Prints on the console the number in reversed order: dcba (in our
        example 1102).
        - Puts the last digit in the first position: dabc (in our example 1201).
        - Exchanges the second and the third digits: acbd (in our example
        2101).*/
        static void ex10()
        {
            Console.WriteLine("write a 4 digit number");
            int number = int.Parse(Console.ReadLine());
            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 100) % 10;
            int a = (number / 1000) % 10;

            Console.WriteLine("the sum of the individual digits are: " + (a + b + c + d));
            Console.WriteLine("the reverse is: " + d + c + b + a);
            Console.WriteLine("with the last digit in front: " + d + a + b + c);
            Console.WriteLine("the second and thrid digit swaped: " + a + c + b + d);
        }

        /*We are given a number n and a position p. Write a sequence of
        operations that prints the value of the bit on the position p in the
        number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35,
        p=6 -> 0.*/
        static void ex11()
        {

        }
    }
}
