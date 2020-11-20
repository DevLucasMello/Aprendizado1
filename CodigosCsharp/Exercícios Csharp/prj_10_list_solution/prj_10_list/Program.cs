using System;
using System.Collections.Generic;

namespace prj_10_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alunos = new List<string>();

            string mais = "s";

            while(mais != "n")
            {
                Console.Write("Digite o nome do aluno: ");
                alunos.Add(Console.ReadLine());

                Console.WriteLine("--------------------------------------------");
                Console.Write("Deseja cadastrar mais alunos? ");
                mais = Console.ReadLine();

            }

            // A linha abaixo faz a contagem de quantos alunos foram cadastrados

            Console.WriteLine("Numero de alunos cadastrados {0}", alunos.Count);

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Alunos cadastrados");

            alunos.Sort();

            alunos.ForEach(i => Console.WriteLine(i));

        }
    }
}
