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
            string resp;
            Console.WriteLine("celsius ou fahrenheit? c/f");
            resp = Console.ReadLine();

            if (resp == "c")
            {
                int c = int.Parse(Console.ReadLine());
                int f = ((c * 9) / 5) + 32;
                Console.WriteLine(f);
            }else if(resp == "f")
            {
                int f = int.Parse(Console.ReadLine());
                int c = ((f - 32) * 5) / 9;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("valor invalido");
            }


        }
    }
}
