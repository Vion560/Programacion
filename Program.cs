using System;

namespace ej3array
{
    class Program
    {
        static void Main(string[] args)
        {
            ej3();
        }
        static void ej3()
        {
            Random r = new Random();
            int[] numRandom = new int[20];
            for(int i = 0; i < numRandom.Length;i++)
            {
                numRandom[i] = r.Next(0,10);
            }
            for(int i = 0; i < numRandom.Length;i++)
            {
                Console.Write(numRandom[i]+ "  ");
            }
            int numberLast = numRandom[19];
            for(int i = 18;i >=0;--i)
            {
                numRandom[i + 1] = numRandom[i];
            }
            numRandom[0] = numberLast;
            Console.WriteLine();
            for (int i = 0; i < numRandom.Length; i++)
            {
                Console.Write(numRandom[i]+ "  ");
            }
        }
    }
}
