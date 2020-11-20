using System;

namespace prj_04_imc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double alt = double.Parse(Console.ReadLine());

            double imc = peso / (alt * alt);

            string result;

            if(imc < 18)
            {
                result = "Abaixo do peso";
            }
            else if((imc >= 18) && (imc < 25))
            {
                result = "Peso ideal";
            }
            else if((imc >= 25) && (imc < 30))
            {
                result = "Sobrepeso";
            }
            else if((imc >= 30) && (imc < 35))
            {
                result = "Obesidade Grau I";
            }
            else if((imc >= 35) && (imc < 40))
            {
                result = "Obesidade Grau II";
            }
            else
            {
                result = "Obesidade Grau III";
            }

            Console.WriteLine("Seu imc é de {0} e o resultado é {1}", imc.ToString("#.##"), result);
        }
    }
}
