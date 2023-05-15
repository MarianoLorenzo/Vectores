using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int[10];
            int acu = 0;
            float prom;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                acu += numeros[x];
            }

            prom = acu / 10;
            Console.WriteLine("El promedio es: " + prom.ToString("0.00"));

            for (int y = 0; y < 10; y++)
            {
                if (numeros[y] > prom)
                {
                    Console.WriteLine(numeros[y] + " este número es mayor al promedio");
                }
            }    
        }
    }
}
