using System;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            Random r = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(0, 11);
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Digite um valor de 0 a 100 para procurar:");
           
            int busc = int.Parse(Console.ReadLine());

            int[] indices = Busca(vetor, busc);

          Console.WriteLine($"O valor {busc} foi encontrado nos índices:");
        
            for (int i = 0; i < vetor.Length; i++)
            {
                if(indices[i] != 0)
                Console.Write(indices[i] + " ");
            }

            Console.ReadLine();
        }

        static int[] Busca(int[] array, int x)
        {
            int cont = 0;
            int[] indices = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    indices[cont] = i;
                    cont++;
                }
            }

            return indices;
        }
    }
}

