using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ej2();
        }
        static void ej2()
        {
            Random r = new Random();
                int[] array = new int[15];
            for(int i=0; i < array.Length; ++i)
            {
                array[i] = r.Next(0, 50);
                Console.WriteLine(array[i]);
            }
            //sacar el valor mas alto
            int higher = array[0];
            int lower = array[1];
            for (int i = 0; i< array.Length;++i)
            {
                if(array[i] > higher)
                {
                    higher = array[i];
                }
                if (array[i] < lower)
                {
                    lower = array[i];
                }
            }
            Console.WriteLine("el mayor es: " + higher + "el menor es: " + lower);
        }
    }
}
