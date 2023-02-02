using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exerciciosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como primeiro exercício do laço 'for', insira a quantidade de números entre 1 e 100 que você deseja que apareça na tela: ");
            int quantidadeNumeros = 0;
            for (int i = 0; i == 0;)
            {
                int numeros = int.Parse(Console.ReadLine());
                if (numeros < 1 || numeros > 100)
                {
                    Console.WriteLine("Quantidade de números inválida, insira novamente:");
                }
                else
                {
                    quantidadeNumeros = numeros;
                    i++;
                }
            }
            Console.WriteLine("Os números são os seguintes:");
            for (int i = 1; i<= quantidadeNumeros; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muito bem!! Agora vamos somar alguns números.");
            int soma = 0;
            for (string parar = "s"; parar == "s";)
            {
                Console.WriteLine("Digite um número para somar:");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
                Console.WriteLine("O total até agora é de: "+soma);
                Console.WriteLine("Deseja somar mais algum número? s/n: ");
                parar = Console.ReadLine();
            }
            Console.WriteLine("Muito bem!! Com isso concluimos nossa prática do laço 'for' :)");
        }
    }
}
