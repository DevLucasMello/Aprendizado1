using System;
using System.Collections.Generic;

namespace prj_14_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> compras = new List<string>();

            string mais = "s";

            while (mais != "n")
            {
                Console.Write("Digite o nome do produto: ");
                compras.Add(Console.ReadLine());

                Console.WriteLine("--------------------------------------------");
                Console.Write("Deseja mais algum item? S (SIM) Ou N (NÂO): ");
                mais = Console.ReadLine();

                Console.Clear();

            }

            // A linha abaixo faz a contagem de quantos produtos foram listados

            Console.WriteLine("Numero de itens comprados {0}", compras.Count);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("ITENS COMPRADOS:");
            Console.WriteLine("");

            compras.Sort();

            compras.ForEach(i => Console.WriteLine(i));
            Console.WriteLine("");

        }
    }
}
