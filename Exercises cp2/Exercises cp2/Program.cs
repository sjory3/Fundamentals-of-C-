using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_cp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ex13();
            Console.ReadLine();
        }

        /*Declare several variables by selecting for each one of them the most
        appropriate of the types sbyte, byte, short, ushort, int, uint, long
        and ulong in order to assign them the following values: 52,130; -115;
        4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
        1990; 123456789123456789.*/
        static void ex1()
        {
            sbyte a = -115;
            sbyte a2 = 97;
            sbyte a3 = 112;
            sbyte a4 = -44;

            byte b = 224;

            short c = -10000;
            short c2 = 20000;
            short c3 = 1990;

            ushort d = 52130;

            int e = 4825932;
            int e2 = -1000000;
            int e3 = 970700000;

            long f = 123456789123456789;
        }

        /*Which of the following values can be assigned to variables of type float,
        double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
        3456.091124875956542151256683467? */
        static void ex2()
        {
            //float: -5.01; 12.345; 5;
            //double 3456.091124875956542151256683467;;
            //decimal 34.567839023; 8923.1234857;
        }

        //Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
        static void ex3()
        {
            float a = 10.000002f;
            float b = 10.000002f;

            if (a == b)
            {
                Console.WriteLine("its the same");
            }
            else
            {
                Console.WriteLine("its not the same");
            }
        }

        /*Initialize a variable of type int with a value of 256 in
        hexadecimal format (256 is 100 in a numeral system with base 16).*/
        static void ex4()
        {
            int number256inhex = 0x100;
            Console.WriteLine(number256inhex);
        }

        /*Declare a variable of type char and assign it as a value the character,
        which has Unicode code, 72 (use the Windows calculator in order to find
        hexadecimal representation of 72).*/
        static void ex5()
        {
            char myChar = '\u0048';
            Console.WriteLine(myChar);
        }

        /*Declare a variable isMale of type bool and assign a value to it depending
        on your gender.
        */
        static void ex6()
        {
            bool isMale;
            Console.WriteLine("are you a male? (Y = YES | N = NO)");
            string respond = Console.ReadLine();

            if (respond == "Y")
            {
                isMale = true;
                Console.WriteLine("you are a male | isMale is set to 'true'");
            }
            else if (respond == "N")
            {
                isMale = false;
                Console.WriteLine("you are not male | isMale is set to 'false'");
            }
            else
            {
                Console.WriteLine("YOU FUCKING MORON");
            }
        }

        /*Declare two variables of type string with values "Hello" and "World".
        Declare a variable of type object. Assign the value obtained of
        concatenation of the two string variables (add space if necessary) to this
        variable. Print the variable of type object.
        */
        static void ex7()
        {
            string hello = "Hello";
            string world = "World";

            object str = hello + " " + world;

            Console.WriteLine(str);
        }

        /*Declare two variables of type string and give them values "Hello" and
        "World". Assign the value obtained by the concatenation of the two
        variables of type string (do not miss the space in the middle) to a
        variable of type object. Declare a third variable of type string and
        initialize it with the value of the variable of type object (you should use
        type casting).*/
        static void ex8()
        {
            string hello = "Hello";
            string world = "World";

            object str = hello + " " + world;

            string total =  str.ToString();

            Console.WriteLine(total);
        }

        /*Declare two variables of type string and assign them a value “The
        "use" of quotations causes difficulties.” (without the outer quotes).
        In one of the variables use quoted string and in the other do not use it.
        */
        static void ex9()
        {
           // string first = "The "use" of quotations causes difficulties.";
            string second = "The \"use\" of quotations causes difficulties.";
        }

        /*Write a program to print a figure in the shape of a heart by the sign "o".*/
        static void ex10()
        {
            Console.WriteLine("       oooooo         oooooo          \n" +
                              "      o      oo     oo      o         \n" +
                              "     o         oo oo         o        \n" +
                              "     o           o           o        \n" +
                              "      o                     o         \n" +
                              "       o                   o          \n" +
                              "        o                 o           \n" +
                              "         o               o            \n" +
                              "          o             o             \n" +
                              "           o           o              \n" +
                              "            o         o               \n" +
                              "             o       o                \n" +
                              "              o     o                 \n" +
                              "               ooooo                  ");
        }

        /*Write a program that prints on the console isosceles triangle which
        sides consist of the copyright character "©"*/
        static void ex11()
        {
            Console.WriteLine("© isosceles triangle \u00a9");
        }

        /*A company dealing with marketing wants to keep a data record of its
        employees. Each record should have the following characteristic – first
        name, last name, age, gender (‘m’ or ‘f’) and unique employee number
        (27560000 to 27569999). Declare appropriate variables needed to
        maintain the information for an employee by using the appropriate data
        types and attribute names.
        */
        static void ex12()
        {
            string firstName;
            string lastName;
            byte age;
            char gender;
            int employeeNumber;
        }

        /*Declare two variables of type int. Assign to them values 5 and 10
        respectively. Exchange (swap) their values and print them.*/
        static void ex13()
        {
            int a = 5;
            int b = 10;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}
