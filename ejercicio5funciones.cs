using System;

namespace ejercicio5funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Esprimo();
        }
        static void Esprimo()
        {
            int num;
            num = 7;
            int counter;
            counter = 2;
            bool prime;
            prime = true;
            do
            {
                if(num % counter == 0)
                {
                    prime = false;
                }
                    counter = counter + 1;
            }
            while (counter <= num);
        }
    }
}
