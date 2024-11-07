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
                vetor[i] = r.Next(0,11);

            }

            Insercao(vetor);

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.WriteLine();
            Console.WriteLine("De um valor de 0  a 10 para Adicionar:");
            int busc = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor foi adicionado ");

            int[] arrayAtualizado = Pesquisa(vetor, busc);

            for (int i = 0; i < arrayAtualizado.Length; i++)
            {
                Console.Write(arrayAtualizado[i] + " ");

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
        static int[] Pesquisa(int[] array, int x)
        {
            int[] arrayAtualizado = new int[array.Length + 1];
            arrayAtualizado = array;
            int resp = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < x )
                {
                    if( array[i+1] > x)
                        resp = i+1;

                }
            }

            for (int i = arrayAtualizado.Length - 2; i >= resp; i--)
            {
                arrayAtualizado[i + 1] = arrayAtualizado[i];
            }

            arrayAtualizado[resp] = 0;

            int dir = array.Length - 1, esq = 0, meio;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;
                if (0 == array[meio])
                {
                    array[meio] = x;

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

            return arrayAtualizado;
        }
    }


}