using System;

namespace ejerciciotarot
{
    class tarot
    {
        static void Main(string[] args)
        {
            ejercicio5();
        }
        static void ejercicio5()
        {
            //calcular el n de tarot
            //año/mes/dia
            //sumando todas las cifras
            Console.WriteLine("mete el dia");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mete el mes");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("mete el año");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tu número es: " + tarotnumber(year, month, day));
        }
        static int tarotnumber(int year, int month, int day)
        {
            int sum;
            sum = year + month + day;
            do
            {
                int acumulador = 0;
                do
                {
                    int aux;
                    //aux coge el resto y los guarda
                    aux = sum % 10;
                    acumulador = acumulador + aux;
                    sum = sum / 10;
                } while (sum != 0);
                sum = acumulador;
            } while (sum >= 10);
            return sum;
        }
    }
}
