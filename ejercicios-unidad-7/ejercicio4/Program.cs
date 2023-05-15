using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nroArticulo, cantidad;
            int[] totalCantidadVendida = new int[15];

            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] = 0;
            }

            Console.WriteLine("Ingrese el número de artículo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                totalCantidadVendida[nroArticulo - 1] += cantidad;
                Console.WriteLine("Ingrese el número de artículo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());
            }

            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;

            for (int x = 0; x <15; x++)
            {
                if (totalCantidadVendida[x] > maxCantidad)
                {
                    maxCantidad = totalCantidadVendida[x];
                    nroMaximo = x + 1;
                }
            }

            Console.WriteLine("El artículo más vendido es: " + nroMaximo + " y la cantidad vendida es: " + maxCantidad);

            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadVendida[x] == 0)
                    Console.WriteLine("El nro de artículo " + (x + 1) + " no registra ventas");
            }

            Console.WriteLine("La cantidad vendida del artículo 10 es: " + totalCantidadVendida[9]);

        }
    }
}
