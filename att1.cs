using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];
            Random r = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(0, 101);
                
            }

            Console.WriteLine("De um valor de 0  a 100 para procurar:");
            int busc = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor esta no indice {Busca(vetor, busc)}");


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.ReadLine();
        }


        static int Busca(int[] array, int x)
        {
            int resp = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    resp = i;
                    return i;
                }

            }

            return resp;
        }


      
    }
}
