using System;

namespace Algoritmo_de_ordenacao
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            int indice = 15;           
            int[] vetor = new int[indice];
            int[] vetor2 = new int[] {30,8,88,78,63,67,54,96,49,64};

            //metodos.VetorAleatorio(vetor);
            //metodos.Imprime(vetor);        
            //vetor = metodos.VetorDecrescente(indice);
            //metodos.Imprime(vetor);
            //metodos.Bubble_Sort(vetor2);
            metodos.Imprime(metodos.Selection_Sort(vetor2));
            
        }
    }
}
