using System;
using System.Security.Cryptography;

namespace ejercicio1
{
    class program
    {
        static void Main(string[] args)
        {
            exercise1();
        }
        static void exercise1()
        {
            Console.WriteLine("Da un número");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numtimes(a));
        }
        static int numtimes(int a2)
        {
            int counter;
            counter = a2 - 1;
            do
            {
                Console.WriteLine(repnum(counter));
                counter = counter - 1;
            }
            while (counter > 0);
            return a2;
        }
        static int repnum(int a3)
        {
            for (int num = 1; num < a3; num++)
            {
                Console.WriteLine(a3);
            }
            return a3;
        }
    }
}
