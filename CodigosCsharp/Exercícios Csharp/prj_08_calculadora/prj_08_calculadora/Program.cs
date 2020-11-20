using System;

namespace prj_08_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "s";
            double n1, n2, result;
            string op;

            result = 0;

            while (cont != "n")
            {
                Console.Write("1° Número: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite a operação: ");
                op = Console.ReadLine();

                Console.Write("2° Número: ");
                n2 = double.Parse(Console.ReadLine());                
                
                switch (op)
                {
                    case "+":
                        result = (n1 + n2);
                        break;

                    case "-":
                        result = (n1 - n2);
                        break;

                    case "*":
                        result = (n1 * n2);
                        break;

                    case "/":
                        result = (n1 / n2);
                        break;

                    case "%":
                        result = (n1 % n2);
                        break;
                        
                    default:
                        break;
                }

                Console.WriteLine("O Resultado é {0}", result);

                Console.WriteLine("Deseja mais alguma operação? S (sim) N (não): ");
                cont = Console.ReadLine();

                if(cont != "n")
                {
                    Console.Clear();
                }
            } 

        }
    }
}
