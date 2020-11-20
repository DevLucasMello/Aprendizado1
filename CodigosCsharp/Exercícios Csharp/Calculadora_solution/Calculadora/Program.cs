using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calcular = new Calculo();//Instanciando a classe Cálculo
            double num1 = 0;
            double num2 = 0;
            int opcao = 0;
            //Fazer um menu com 4 opções
            do
            {
                Console.Write("*** Bem Vindo ***\n\n\n" +
                                "0. Sair do programa\n" +
                                "1. Somar\n" +
                                "2. Subtratir\n" +
                                "3. Multiplicar\n" +
                                "4. Dividir\n" +
                                "Escolha uma das opções acima: ");
                //Ler a escolha do usuário
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao >= 1 && opcao <= 4)
                {
                    //Coletando os 2 números               
                    Console.WriteLine("Informe um número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\nInforme outro número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    if (opcao == 0)
                    {
                        Console.WriteLine("Obrigado.");
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
                }//Fim do If            

                //Escolha_caso
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("A soma é: " + calcular.Somar(num1, num2));
                        break;

                    case 2:
                        Console.WriteLine("A subtração é: " + calcular.Subtrair(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("A multiplicação é: " + calcular.Multiplicar(num1, num2));
                        break;
                    case 4:
                        while (calcular.num2 <= 0)
                        {
                            Console.WriteLine("Impossível dividir por zero! Digite novamente: ");
                            calcular.AlterarNum2 = Convert.ToInt32(Console.ReadLine());
                        }//Fim do While
                        Console.WriteLine("A divisão é: " + calcular.Dividir(num1, num2));
                        break;
                    default:
                        if (opcao != 0)
                        {
                            Console.WriteLine("Valor Inválido! Digite Novamente: ");
                        }
                        break;
                }//Fim do escolha_caso
            } while (opcao != 0);
        }//Fim do Método Principal
    }//Fim da Classe
}//Fim do Projeto
