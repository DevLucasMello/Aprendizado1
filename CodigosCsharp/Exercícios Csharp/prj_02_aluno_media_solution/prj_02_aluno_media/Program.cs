using System;

namespace prj_02_aluno_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota 1 do (a) {0}: ", nome);
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2 do (a) {0}: ", nome);
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a frequência do(a) {0}: ", nome);
            double freq = double.Parse(Console.ReadLine());

            // a linha abaixo é para o processamento das informações

            double media = (n1 + n2) / 2;

            string status;

            if((media >=6) && (freq >= 75))
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }

            // a linha abaixo é para saída de dados

            Console.WriteLine("{0} você está {1} com média {2} e com frequência {3}%", nome, status, media, freq);
        }
    }
}
