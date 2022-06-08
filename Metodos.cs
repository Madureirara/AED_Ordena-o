using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Algoritmo_de_ordenacao
{
    class Metodos
    {
        public void Imprime(int[]vetor) 
        {
            Console.Write("[ ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"{vetor[i]} ,");
            }
            Console.WriteLine("]");
        }
        public int[] VetorAleatorio(int[]vetor)
        {           
            Random r = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {                
                vetor[i] = (int)r.Next(0, 20);
            }
            return vetor;
        }
        public int[] VetorDecrescente(int n)
        {
            int[] vetor=new int[n];
            for (int i = 0; i < n; i++)
            {
                vetor[i] = (vetor.Length - 1) - i;
            }
            return vetor;
        }
        //public int[] VetorCrescente(int[]vetor)
        //{

        //}
        public void Bubble_Sort(int[] vet)
        {
            int n=0;
            n= vet.Length;
            for (int i = n-2; i < n; i++)
            {
                for (int j = n-1; j > n; j++)
                {

                }
            }
        }
        public int[] Selection_Sort(int[] vet)
        {
            int min_pos;
            int min_value;
            int auxiliar;
            for (int i = 0; i < vet.Length-1; i++)
            {
                min_pos = i;
                min_value = vet[i];

                for (int j = i+1; j <vet.Length; j++)
                {
                    if (vet[j] < vet[min_pos])
                    {
                        min_pos = j;                     
                    }                                          
                }
                auxiliar = vet[i];
                vet[i] = vet[min_pos];
                vet[min_pos] = auxiliar;
                
            }
            return vet;
        }
    }
}
