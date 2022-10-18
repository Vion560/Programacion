using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int base = ConvertToInt32(Console.ReadLine());
            int exp = ConvertToInt32(Console.ReadLine());
            Console.WriteLine("El resultado es"+ Power2(base,exp))
        }
        static float Power2(int _base, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }

            if(exp > 0)
            {
                //potencia
                int total = _base;
                int counter = 1;
                while( counter < exp)
                {
                    total = total * _base;
                    counter = counter + 1;
                }
                return total;
            }
        }
    }
}
