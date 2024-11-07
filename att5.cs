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
            int[] vetor = new int[10];
            Random r = new Random();


            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = r.Next(0,10);

            }

           
            Console.WriteLine($"O valor esta no indice {Busca(vetor)}");


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " ");

            }

            Console.ReadLine();
        }


        static bool Busca(int[] array)
        {
          

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i+1] )
                {
                   return  false;    
                }
               

            }



            return true;
        }



    }
}