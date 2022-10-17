using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            b = 5;

            Multiplos(b);
        }
        static int Multiplos(int num)
        {
            //num es el numero que se queda guardado de b(5)
            int a;
            int multiplicador;
            multiplicador = 1;
            do
            {
                a = int.Parse(Console.ReadLine());
                if ((a % num) == 0)
                {
                    multiplicador = multiplicador * a;
                }               
            }
            while (a != 0);
            { return a; }
        }                  
    }
}
