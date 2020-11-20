using System;

namespace prj_07_login_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 3)
            {

                Console.Write("Digite seu login: ");
                string login = Console.ReadLine();

                Console.Write("Digite seua senha: ");
                string senha = Console.ReadLine();

                if ((login == "programador") && (senha == "sistemas"))
                {
                    Console.WriteLine("Logado com sucesso!!");
                    break;
                }
                else
                {
                    if (i <= 3)
                    {
                        Console.WriteLine("Dados incorretos. Tente Novamente: ");
                    }

                    i++;
                }

                if (i > 3)
                {
                    Console.WriteLine("Conta Bloqueada!!!");
                }

            }
        }
    }
}