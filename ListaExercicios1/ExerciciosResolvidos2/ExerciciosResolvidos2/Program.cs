using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosResolvidos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Pretende-se lendo a base e altura de um triângulo calcular sua área.
            Console.WriteLine("Digite a base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            double area = (baseTriangulo*alturaTriangulo)/2;
            Console.WriteLine("A área do triângulo é de: " + area);

            //5- Faça um programa que receba um valor que é o valor pago, um segundo valor que é o preço do produto e retorne o troco a ser dado.

            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor pago: ");
            double valorPago = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor do troco é de: "+ (valorPago-preco));

            //6- Faça um programa que receba o valor do quilo de um produto e a quantidade de quilos do produto consumida calculando o valor final a ser pago.
            Console.WriteLine("Insira o valor do quilo do produto: ");
            double valorQuilo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de quilos consumida: ");
            double quantidadeConsumida = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor final a ser pago é de: "+ (valorQuilo*quantidadeConsumida));
        }
    }
}
