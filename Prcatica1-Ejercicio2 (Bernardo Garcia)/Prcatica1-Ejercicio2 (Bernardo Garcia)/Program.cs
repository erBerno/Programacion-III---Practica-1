using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prcatica1_Ejercicio2__Bernardo_Garcia_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            Random r = new Random();

            Console.WriteLine("Ejercicio 2");

            Console.WriteLine("Vector Desordenado:");
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = r.Next(0, 50);
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Vector Ordenado:");

            for (int j = 0; j < vector.Length; j++)
            {
                for (int k = 0; k < vector.Length - 1; k++)
                {
                    if (vector[k] > vector[k + 1])
                    {
                        int aux;
                        aux = vector[k];
                        vector[k] = vector[k + 1];
                        vector[k + 1] = aux;
                    }
                }
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }



            Console.ReadKey();
        }
    }
}
