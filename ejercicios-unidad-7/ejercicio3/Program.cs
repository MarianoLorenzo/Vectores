using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cadena = new char[50];
            char c1, c2, letra;
            int conCarac = 0;

            Console.WriteLine("Ingrese la cadena de caracteres: ");
            letra = char.Parse(Console.ReadLine());
            while (letra != '.' && conCarac < 50)
            {
                cadena[conCarac] = letra;
                letra = char.Parse(Console.ReadLine());
                conCarac++;
            }
            
            cadena[conCarac + 1] = '\0';

            Console.WriteLine("Ingrese el primer caracter: ");
            c1 = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo caracter: ");
            c2 = char.Parse(Console.ReadLine());

            conCarac = 0;

            while (cadena[conCarac] != '\0')
            {
                if (cadena[conCarac] == c1)
                    cadena[conCarac] = c2;
                
                Console.Write(cadena[conCarac]);
                conCarac++;
            }
        }
    }
}
