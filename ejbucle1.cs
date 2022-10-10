using System;

namespace bucleejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            int number;
            counter = 1;
            Console.WriteLine("Escriba un número");
            number = int.Parse(Console.ReadLine());
            while (counter < number)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
        }
    }
}
