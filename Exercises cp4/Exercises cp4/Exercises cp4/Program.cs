using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_cp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ex5();
            Console.ReadLine();

        }

        /*Write a program that reads from the console three numbers of type int
        and prints their sum.*/
        static void ex1()
        {
            Console.WriteLine("enter number 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number 3");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine((a + b + c));
        }

        /*Write a program that reads from the console the radius "r" of a circle
        and prints its perimeter and area.
        */
        static void ex2()
        {
            Console.WriteLine("enter r");
            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * (r * r);
            double perimeter = (r * 2) * Math.PI;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }

        /*A given company has name, address, phone number, fax number, web
        site and manager. The manager has name, surname and phone number.
        Write a program that reads information about the company and its
        manager and then prints it on the console.
        */
        static void ex3()
        {
            string companyName = "some Company";
            string companyAddress = "some address for a company";
            int companyPhoneNumber = 15452535;
            int companyFax = 151351;
            string companyWebSite = "www.somecompany.com";

            string managerName = "Som ting";
            string managerSurName = "Wong";
            int managerPhoneNumber = 45256585;

            Console.WriteLine("Company name: " + companyName);
            Console.WriteLine("Company address: " + companyAddress);
            Console.WriteLine("Company Phone Number: " + companyPhoneNumber);
            Console.WriteLine("Company Fax: " + companyFax);
            Console.WriteLine("Company Website: " + companyWebSite);
            Console.WriteLine("\nManager Name: " + managerName);
            Console.WriteLine("Manager Surname: " + managerSurName);
            Console.WriteLine("Manager Phone Number: " + managerPhoneNumber);
        }

        /*Write a program that prints three numbers in three virtual columns
        on the console. Each column should have a width of 10 characters and
        the numbers should be left aligned. The first number should be an
        integer in hexadecimal; the second should be fractional positive; and
        the third – a negative fraction. The last two numbers have to be
        rounded to the second decimal place*/
        static void ex4()
        {
            int hexValue = 0x8584;
            float positive = 1.97f;
            float negative = -1.97f;
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Hex", "|Positive", "|Negative");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", hexValue, "|" + positive, "|" + negative);
        }

        /*Write a program that reads from the console two integer numbers (int)
        and prints how many numbers between them exist, such that the
        remainder of their division by 5 is 0. Example: in the range (14, 25)
        there are 3 such numbers: 15, 20 and 25.*/
        static void ex5()
        {
            Console.WriteLine("input a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input b");
            int b = int.Parse(Console.ReadLine());
            int c;

            if (a < b == true)
            {
                c = b - a;

                for (int i = a; i <= (c+a); i++)
                {
                    if (i%5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                c = a - b;

                for (int i = b; i <= (c+b); i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }

    }
}
