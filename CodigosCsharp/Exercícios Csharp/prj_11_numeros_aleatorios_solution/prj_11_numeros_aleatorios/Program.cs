using System;

namespace prj_11_numeros_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];

            int maior = -999999999;
            int menor = 999999999;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                
                if (numeros[i] > maior);
                {
                    maior = numeros[i];                    
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("O maior número digitado foi {0}", maior);
            Console.WriteLine("O menor número digitado foi {0}", menor);
            Console.WriteLine("A soma dos valores é {0}", maior + menor);
        }
    }
}
