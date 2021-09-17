using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2ora_20210917
{
    class Program
    {
        static void Main(string[] args)
        {
            //           testomeg();
            //           kiiratas();

            //           teszt1();
            //           teszt2();

            //           csere();
            boolszamitas();


            Console.ReadKey();

        }
        static void testomeg()
        {
            Console.Write("Testömeg (kg):");
            string be = Console.ReadLine();
            int kg = Convert.ToInt32(be);
            Console.Write("Magasság (cm):");
            string bee = Console.ReadLine();
            int cm = Convert.ToInt32(bee);
            double m = cm / 10;
            double tti = kg / m * m;
            Console.WriteLine("tti:" + tti);
            Console.ReadKey();
        }
        static void kiiratas()
        {
            Console.Write("Család Név:");
            string fn = Console.ReadLine();
            Console.Write("Keresztnév: ");
            string kn = Console.ReadLine();
            Console.WriteLine(("{0}, {1}"), fn, kn);
            Console.WriteLine();

            //--- eredmény: Sallai, Martin
        }
        static void teszt1()
        {
            int x = 3;
            Console.WriteLine(x / 4);

            //--- eredmény : 0
        }
        static void teszt2 ()
        {
            int x = 3;
            double dtemp = 3 / 4;
            Console.WriteLine("x/4=" + x / 4 + "   dtemp: " + dtemp);

            //--- eredmény : 0 , 0
        }
        static void csere()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int x = 6;
            // x segédváltozo segítségével vegye fel az A-t, továbbá B = C, C = A, értékeket //
            // mivel x nem assigned variable, be irtam a hatot mert különben nem működik//
            // int x; egyenlő erroral //
            
            Console.WriteLine(("{0},{1},{2},{3}"), a, b, c, x);
            Thread.Sleep(2000);

            x = a;
            b = c;
            c = a;
            Console.WriteLine(("{0},{1},{2},{3}"), a, b, c, x);         
        }
        static void boolszamitas()
        {
            
            bool a = true;
            bool b = false;
            Console.WriteLine("A igaz, B hamis");
           // Console.WriteLine("A és B" a&&b "\tA és nem B:" a&&!b);
            Console.WriteLine(("{0},\t{1}"), a && b, a && !b);
        }
    }
}
