using System;
using System.Collections.Generic;

namespace prj_13_candidatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string nova = "";

                string[] candi = new string[3];
                int[] nCandi = new int[3];
                int[] qtdVotos = new int[4];

                candi[0] = "Dedé";
                nCandi[0] = 26;
                candi[1] = "Joaquim";
                nCandi[1] = 32;
                candi[2] = "Sebastião";
                nCandi[2] = 99;

                while (nova != "n")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Tecle {0} para votar no {1}", nCandi[i], candi[i]);

                    }

                    Console.WriteLine("");
                    Console.Write("Escolha seu Candidato: ");
                    int voto = int.Parse(Console.ReadLine());

                    if (voto < 0)
                    {
                        Console.WriteLine("Número do voto inválido. Você só pode digitar valores positivos");
                    }

                    switch (voto)
                    {
                        case 26:
                            qtdVotos[0]++;
                            break;
                        case 32:
                            qtdVotos[1]++;
                            break;
                        case 99:
                            qtdVotos[2]++;
                            break;
                        default:
                            qtdVotos[3]++;
                            break;
                    }

                    Console.Write("Deseja votar novamente: ");

                    nova = Console.ReadLine();

                    while ((nova != "n") && (nova != "s"))
                        Console.WriteLine("Comando inválido! Você só pode digitar S (SIM) Ou N (NÂO)");
                        Console.ReadLine();

                    Console.Clear();
                }

                /*
                for(int i=0; i < 3; i++)
                {
                    Console.WriteLine("O candidato {0} teve {1} votos", candi[i], qtdVotos[i]);
                }

                Console.WriteLine("Houve {0} votos nulos", qtdVotos[3]);            
                */

                string result = "";

                if ((qtdVotos[0] > qtdVotos[1]) && (qtdVotos[0] > qtdVotos[2]))
                {
                    result = "O candidato " + candi[0] + " foi eleito com " + qtdVotos[0] + " votos";
                }
                else if ((qtdVotos[1] > qtdVotos[0]) && (qtdVotos[1] > qtdVotos[2]))
                {
                    result = "O candidato " + candi[1] + " foi eleito com " + qtdVotos[1] + " votos";
                }

                else if ((qtdVotos[2] > qtdVotos[1]) && (qtdVotos[2] > qtdVotos[1]))
                {
                    result = "O candidato " + candi[2] + " foi eleito com " + qtdVotos[2] + " votos";
                }

                else if (qtdVotos[0] == qtdVotos[1])
                {
                    result = "Os candidatos " + candi[0] + " e " + candi[1] + " empataram, portanto haverá 2° turno";
                }
                else if (qtdVotos[0] == qtdVotos[2])
                {
                    result = "Os candidatos " + candi[0] + " e " + candi[2] + " empataram, portanto haverá 2° turno";
                }
                else
                {
                    result = "Os candidatos " + candi[2] + " e " + candi[1] + " empataram, portanto haverá 2° turno";
                }

                Console.WriteLine(result);

                int total = qtdVotos[0] + qtdVotos[1] + qtdVotos[2] + qtdVotos[3];
                Console.WriteLine("O total de eleitores é {0}", total);
                Console.WriteLine("O número de votos nulos foi de {0}", qtdVotos[3]);
            }
            catch(Exception)
            {
                Console.WriteLine("Ocorreu um erro inesperado");
            }
        }
    }
}
