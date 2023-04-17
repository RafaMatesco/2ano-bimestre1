/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 28/03/2022
 * Autores do Projeto: Rafael Giordano Matesco 50210686
 *                     Arthur Henrique Castro Miranda 50210117
 * Turma: 2H
 * Atividade Proposta em aula
 * Observação: <colocar se houver>
 * 
 * projeto.cs
 * ************************************************************/

class HelloWorld
{

    static void Main()
    {
        int x;
        int curso = 0;
        int salario = 0;
        int idade = 0;
        
        int media_sal_3 = 0;
        int media_sal_ma25 = 0;
        int tot_sal_3 = 0;
        int tot_sal_ma25 = 0;
        int e1 = 0;
        int e2 = 0;

        int media_sal_2 = 0;
        int media_sal_me25 = 0;
        int tot_sal_me25 = 0;
        int tot_sal_2 = 0;
        int f1 = 0;
        int f2 = 0;

        int idade_med = 0;
        int g1 = 0;

        int h1 = 0;

        int i1 = 0;

        int d = 0;
        int e = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        int i = 0;

        Console.WriteLine("Quantas pessoas vão ser testadas? ");
        int grupo = int.Parse(Console.ReadLine());

        for (x = 1; x <= grupo; x++)
        {
            Console.Write("Pessoa ");
            Console.Write(x);
            Console.WriteLine(", qual seu grau de intrução? [1] primário [2] medio [3] superior");
            curso = int.Parse(Console.ReadLine());
            Console.WriteLine("qual sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do seu salário?");
            salario = int.Parse(Console.ReadLine());
            if (curso == 3)
            {
                tot_sal_3 += salario;
                e1++;
                i1++;
            }
            if(idade > 25)
            {
                tot_sal_ma25 += salario;
                e2++;
            }
            if(idade < 25)
            {
                tot_sal_me25 += salario;
                f1++;
            }
            if(curso == 2)
            {
                tot_sal_2 += salario;
                f2++;
                idade_med += idade;
                g1++;
            }
            if(curso == 1)
            {
                h1++;
            }

            //LETRA D
            if ((curso == 3) && (salario < 500))
            {
                d++;
            }
            
        }
        //LETRA E
        media_sal_3 = tot_sal_3 / e1;
        media_sal_ma25 = tot_sal_ma25 / e2;
        e = media_sal_3 - media_sal_ma25;


        //LETRA F
        media_sal_2 = tot_sal_2 / f1;
        media_sal_me25 = tot_sal_me25 / f2;
        f = media_sal_me25 - media_sal_2;

        //LETRA G
        g = idade_med / g1;

        //LETRA H
        h = (h1 / grupo)*100;

        //LETRA I
        i = (i1 / grupo) * 100;
    }
}