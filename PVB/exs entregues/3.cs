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
            int x = int.Parse(Console.ReadLine());
            bool par = false;
            bool impar = false;

            if (x % 2 == 0)
            {
                par = true;
                Console.Write("par = ");
                Console.WriteLine(par);
            }
            else
            {
                impar = true;
                Console.Write("impar = ");
                Console.WriteLine(impar);
            }
        }
    }
}
