using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1 exec1 = new Exercicio1();//Instanciando a Classe Exercicio1
            Exercicio3_4 exec3_4 = new Exercicio3_4();//Instanciando a Classe Exercício 3_4
            Exercicio5_6 exec5_6 = new Exercicio5_6();//Instanciando a Classe Exercício 5_6

            /*int num = 0;
            double base1 = 0;
            double altura1 = 0;
            int ano = 0;
            int mes = 0;
            int dia = 0;
            string resp = "s";*/

            /*Console.WriteLine("Resposta ecercício 1: ");
            exec1.Trocar();//Resposta do Exercício 1

            Console.WriteLine("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O Antecessor é: " + exec1.Antecessor(num));//Resposta exercício 2

            Console.WriteLine("Digite a base: ");
            base1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            altura1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A área é: " + exec3_4.Area(base1,altura1));//Resposta exercício 3*/

            /*do
            {
                Console.WriteLine("Digite sua idade em: ");
                Console.WriteLine("Quantidade de anos: ");
                ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantidade de meses: ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantidade de dias: ");
                dia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sua idade em dias é = " + exec3_4.Dias(ano, mes, dia));//Resposta exercício 4
                Console.WriteLine("Deseja simular mais alguma idade [S/N]: ");
                resp = Console.ReadLine();
                if (resp != "s" || resp != "n")
                {
                    Console.WriteLine("Resposta Incorreta! Digite S-Sim ou N-Não: ");
                    resp = Console.ReadLine();
                }//Fim da validação da resposta
            } 
            while (resp == "s");*/
            //Fim do laço de repetição da resposta

            Console.WriteLine("Digite a quantidade de eleitores: ");
            int eleitores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos brancos: ");
            int brancos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos nulos: ");
            int nulos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de votos válidos: ");
            int validos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total de eleitores = "           + exec5_6.TotEleitores   + "\n"  +
                              "Percentual de votos brancos = "  + exec5_6.percentual1    + "%\n" +
                              "Percentual de voto nulos = "     + exec5_6.percentual2    + "%\n" +
                              "Percentual de votos válidos = "  + exec5_6.percentual3    + "%\n");

        }//Fim do Método Main
    }//Fim da Classe Program
}//Fim do Projeto
