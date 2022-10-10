using System;

namespace ejbucle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            counter = 1;
            while (counter < 100)
            {
                Console.WriteLine(counter);
                counter = counter + 5;
            }
            Console.WriteLine("FIN");
        }
    }
}
