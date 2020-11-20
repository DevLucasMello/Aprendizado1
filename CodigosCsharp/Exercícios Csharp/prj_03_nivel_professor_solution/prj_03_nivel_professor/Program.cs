using System;

namespace prj_03_nivel_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Professor digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a quantidade de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Digite seu nível: ");
            int nivel = int.Parse(Console.ReadLine());

            decimal salario = 0;

            bool valida = true;

            switch(nivel)
            {
                case 1:
                    salario = horas * 12;
                    break;
                case 2:
                    salario = horas * 17;
                    break;
                case 3:
                    salario = horas * 25;
                    break;
                default:
                    Console.WriteLine("Nível inválido!!!");
                    valida = false;
                    break;                    
            }

            if (valida)
            {
                Console.WriteLine("Professor {0} seu salário é R$ {1} com base no seu nível que é {2}", nome, salario, nivel);
            }
        }
    }
}
