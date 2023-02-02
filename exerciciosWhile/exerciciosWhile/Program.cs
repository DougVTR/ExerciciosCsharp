using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercíciosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O 'while' é muito útil em situações onde você queira utilizar uma estrutura de repetição da qual não se sabe quando será finalizada.");
            Console.WriteLine("Vamos ver na prática essa questão.");
            Console.WriteLine();
            bool parar = false;
            while(parar == false)
            {
                Console.WriteLine("A estrutura de repetição esta sendo executada. Para finaliza-la, digite 'fim'.");
                string decisao;
                decisao= Console.ReadLine();
                if(decisao == "fim")
                {
                    Console.WriteLine("Fim do laço de repetição :)");
                    parar= true;
                }
            }
            Console.WriteLine("Também é possível utilizar o 'Do while', que irá executar pelo menos uma vez o laço.");
            int numero = 0;
            do
            {
                Console.WriteLine("Aqui já estamos dentro do laço de repetição. Para testar, escreva qualquer número que será elevado a 2. Para parar digite 0'");
                numero = int.Parse(Console.ReadLine());
                numero *= numero;
                Console.WriteLine("Resultado: "+ numero);

            } while (numero !=0);
            Console.WriteLine("Fim do laço de repetição :)");
        }
    }
}

