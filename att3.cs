using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];
            Random r = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;

            }

            Console.WriteLine("De um valor de 0  a 100 para procurar e contar quntas vezes ele aparece:");
            int busc = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor aparece: {Busca(vetor, busc)}");


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.ReadLine();

        }

        static int Busca(int[] array, int x)
        {
            int cont = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    cont++;
                    
                }

            }

            return cont;
        }


    }
}
