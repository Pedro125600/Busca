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

            int[,] matriz = new int[10,5];

            int cont = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = cont;
                    cont++;
                }

            }
   
            Console.WriteLine("De um valor de 0  a 10 para procurar:");
            int busc = int.Parse(Console.ReadLine());

            Console.WriteLine($"O valor esta no indice {Pesquisa(matriz, busc)}");


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

     

        static int Pesquisa(int[,] array, int x)
        {
            int resp = -1;


            for (int i = 0; i < array.GetLength(0); i++)
            {

                int dir = array.GetLength(1) - 1, esq = 0, meio = 0;
                while (esq <= dir)
                {
                    meio = (esq + dir) / 2;

                    if (x == array[i,meio])
                    {
                        resp = meio;
                        esq = array.Length - 1;
                    }
                    else if (x > array[i,meio])
                    {
                        esq = meio + 1;
                    }
                    else
                    {
                        dir = meio - 1;
                    }
                }
            }
            return resp;
        }
    }


}