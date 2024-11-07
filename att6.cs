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

            Console.WriteLine("De um valor de 0  a 10 para procurar o mais proximo dele:");
            int busc = int.Parse(Console.ReadLine());

            Insercao(vetor);

            Console.WriteLine($"O valor esta no indice {Pesquisa(vetor, busc)}");


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

        static int Pesquisa(int[] array, int x)
        {
            int[] resp = { -1, -1 };



            int dir = array.Length - 1, esq = 0, meio;
            while (esq <= dir)
            {
                meio = (esq + dir) / 2;

                if (x == array[meio])
                {
                    resp[0] = meio;
                    dir = meio - 1;


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

            esq = 0;
            dir = array.Length - 1;

            while (esq <= dir)
            {
                meio = esq + (dir - esq) / 2;

                if (array[meio] == x)
                {
                    resp[1] = meio;
                    esq = meio + 1;
                }

                else if (array[meio] > x)
                {
                    dir = meio - 1;
                }
                else
                {
                    esq = meio + 1;
                }

            }
            int resposta = 0;

            if (resp[0] == -1 && resp[1] == -1 && resp[0] != resp[1] && resp[0] != 0)
            {
                int maior = -1;
                int menor = -1;

                
                maior = array[resp[1] + 1];
                menor  = array[resp[0] - 1];
                
                if (maior - x < x - menor)
                {
                    resposta = maior;
                }
                else if(menor != -1) 
                {
                    resposta = menor;
                }
                else
                {
                    resposta = maior;
                }

            }

            else if(resp[0] == resp[1] && resp[0] == 0 && resp[1] == 0)
            {
                int maior = array[resp[0] + 1];
                int menor = array[resp[1] - 1];


                if (maior - x < x - menor)
                {
                    resposta = maior;
                }
                else if (menor != -1)
                {
                    resposta = menor;
                }
                else
                {
                    resposta = maior;
                }
            }

            else
            {
                resposta= array[resp[0] + 1];
            }
            return resposta;

        }
    }
}