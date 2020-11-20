using System;

namespace prj_01_trabalhando_com_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá {0} você tem {1} anos.", nome, idade);
        }
    }
}
