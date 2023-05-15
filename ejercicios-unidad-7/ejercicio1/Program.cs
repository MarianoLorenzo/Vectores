using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];
            int n, max = 0, posicion = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                numeros [x] = n;

                if (n > max)
                {
                    max = n;
                    posicion = x + 1;
                }    
            }
            
            Console.WriteLine("El máximo es " + max + " y está en la posición " + posicion);
        }
    }
}
