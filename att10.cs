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
                vetor[i] = r.Next(0, 10);

            }

            Console.WriteLine("De um valor de 0  a 10 para procurar:");
            int busc = int.Parse(Console.ReadLine());

            Insercao(vetor);

            Console.WriteLine($"O valor esta no indice {Pesquisa(vetor,busc,0,vetor.Length-1)}");


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.ReadLine();
        }

        static void Insercao(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int tmp = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j] > tmp))
                {
                    array[j + 1] = array[j];
                    j--;

                }
                array[j + 1] = tmp;


            }
        }

        static int Pesquisa(int[] array, int x,int esq, int dir)
        {
            if (esq > dir)
            {
                return -1;
            }

            int meio = (esq + dir) / 2;

            if (x == array[meio])
            {
                return meio; 
            }
            else if (x > array[meio])
            {
                return Pesquisa(array, x, meio + 1, dir); 
            }
            else
            {
                return Pesquisa(array, x, esq, meio - 1); 
            }

        }
    }


}

