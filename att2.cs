using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];
            Random r = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i;

            }

            Console.WriteLine("De um valor de 0  a 10 para procurar:");
            int busc = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor esta no indice {Pesquisa(vetor, busc)}");


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.ReadLine();

        }


        static int Pesquisa(int[] array, int x) 
        {
            int resp = -1;
          
            int dir = array.Length - 1, esq = 0, meio;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;
                if (x == array[meio])
                {
                    resp = meio;
                    esq = array.Length - 1;
                }
                else if (x > array[meio])
                {
                    esq = meio + 1;
                }
                else
                {
                    dir = meio - 1;
                }
            }

            return resp;
        }
    }


}
