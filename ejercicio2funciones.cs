using System;

namespace ejercicio2funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es el menú de opciones del día");
            Console.WriteLine("elige una de las opciones");
            Console.WriteLine("Opción 1: Lista de comida");
            Console.WriteLine("Opción 2: Deporte");
            Console.WriteLine("Opción 3: Coches");
            Console.WriteLine("Opción 4: Ordenadores");
            Console.WriteLine("Opción 5: Música");
            Console.WriteLine(menu());
        }
        static string menu()
        {
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:return "Has elegido opción 1"; break;
                case 2: return "Has elegido opción 2"; break;
                case 3: return "Has elegido opción 3"; break;
                case 4: return "Has elegido opción 4"; break;
                case 5: return "Has elegido opción 5"; break;
                default: return "No has elegido menú"; break;
            }
        }
    }
}
