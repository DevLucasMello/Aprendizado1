using System;

namespace prj_09_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[4];

            for(int i = 0; i < 4; i++)
            {
                Console.Write("Digite o nome do aluno: ");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("-------------------------------");

            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);
            }            
        }
    }
}
