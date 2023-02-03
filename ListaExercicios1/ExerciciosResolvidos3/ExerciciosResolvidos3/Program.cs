using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7- Faça um programa que receba 2 valors e retorne o maior entre eles.  
            double maior = 0, menor = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o "+(i+1)+"° valor: ");
                double valor = double.Parse(Console.ReadLine());
                if(valor > maior)
                {
                    maior = valor;
                }
            }
            Console.WriteLine("O maior valor é o " + maior);

            // 8 - Faça um programa que recebe 4 valores e retorne o menos entre eles.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "° valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = valor1;
                }
                if (valor1 < menor)
                {
                    menor = valor1;
                }
            }
            Console.WriteLine("O menor número entre os 4 números é o: "+ menor);

            //9 - Faça um programa que verifique se um número é ímpar.

            Console.WriteLine("Digite o número que deseja verificar se é impar: ");
            double impar = double.Parse(Console.ReadLine());
            if(impar %2 != 0)
            {
                Console.WriteLine("O número é impar!!");
            }
            else
            {
                Console.WriteLine("O número é par!!");
            }
        }
    }
}
