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
            ex3();
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

    }
}
