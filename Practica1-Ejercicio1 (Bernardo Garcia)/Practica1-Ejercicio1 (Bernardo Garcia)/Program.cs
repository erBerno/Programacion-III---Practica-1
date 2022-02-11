using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_Ejercicio1__Bernardo_Garcia_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("Ingrese el tamaño del vector:");
            int tam = int.Parse(Console.ReadLine());

            string[] vector = new string[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Ingrese el Nombre de la Persona " + i);
                vector[i] = Console.ReadLine();
            }

            for (int i = 0;i < tam; i++)
            {
                Console.WriteLine(i + " - " + vector[i]);
            }





            Console.ReadKey();
        }
    }
}
