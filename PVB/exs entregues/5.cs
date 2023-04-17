using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Disciplina - POO -I (2o Anos Informática)
            (Lista referente a Primeira Parte do Curso)
            Todos os exercícios abaixo relacionados
            Devem ser resolvidos usando modelo console
            Para resolver corretamente os exercícios é necessário foco no

            Material fornecido no site.*/
            int qtde = int.Parse(Console.ReadLine());
            int anterior = 0;
            int atual = 1;
            int contador = 1;
            int proximo = 0;
            while(contador <= qtde)
            {
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
                contador++;
            }
            Console.Write("Fibonacci ");
            Console.Write(qtde);
            Console.Write(" = ");
            Console.WriteLine(anterior);
        }
    }
}
