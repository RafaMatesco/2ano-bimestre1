using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Disciplina - POO -I (2o Anos Inform�tica)
            (Lista referente a Primeira Parte do Curso)
            Todos os exerc�cios abaixo relacionados
            Devem ser resolvidos usando modelo console
            Para resolver corretamente os exerc�cios � necess�rio foco no

            Material fornecido no site.*/
            int max = 0;
            int a = int.Parse(Console.ReadLine());
            if(a> max)
            {
                max = a;
            }
            int b = int.Parse(Console.ReadLine());
            if(b> max)
            {
                max = b;
            }
            int c = int.Parse(Console.ReadLine());
            if(c> max)
            {
                max = c;
            }
            Console.WriteLine(max);

        }
    }
}