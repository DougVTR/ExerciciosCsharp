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
        }
    }
}

