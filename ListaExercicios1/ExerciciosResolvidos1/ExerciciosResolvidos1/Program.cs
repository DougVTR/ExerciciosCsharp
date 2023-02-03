using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Crie um algoritmo que lê o nome de uma pessoa e escreve "Olá" seguido do nome da pessoa.
            Console.WriteLine("Por favor, digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá "+nome);

            //2 - Crie um algoritmo que após ler dois números inteiros apresenta a sua soma. 

            Console.WriteLine("Digite o primeiro número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num += int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos números é de  :"+ num);

            //3 - Crie um algoritmo que após ler dois números inteiros apresenta a sua diferença.

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num1 -= int.Parse(Console.ReadLine());
            Console.WriteLine("A diferença dos números é de :" + num1);
        }
    }
}
