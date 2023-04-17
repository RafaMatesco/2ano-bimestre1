using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){   
            int contador_divisil3=0;
            int contador_divisil5=0;
            int numero_1=0;
            bool resposta_usuario=false;
            Console.WriteLine("   deseja testar algum numero? (sim = true/não = false) ");
            resposta_usuario = bool.Parse(Console.ReadLine());
            while(resposta_usuario==true){
                
                
                Console.WriteLine("   digite o valor que deseja testar: ");
                numero_1 = int.Parse(Console.ReadLine());
                if((numero_1%3==0) && (numero_1%5==0)){
                    contador_divisil3++;
                    contador_divisil5++;
                }else{
                    if(numero_1%3==0){
                        contador_divisil5++;
                    }else{ 
                        if(numero_1%5==0){
                            contador_divisil5++;
                        }
                    }
                }
                Console.WriteLine("   deseja testar mais algum numero? (sim = true/não = false) ");
                resposta_usuario = bool.Parse(Console.ReadLine());
            }
            Console.Write("   numeros multiplos de 3: ");
            Console.WriteLine(contador_divisil3);
            Console.Write("   numeros multiplos de 5: ");
            Console.WriteLine(contador_divisil5);
        }
    }
}