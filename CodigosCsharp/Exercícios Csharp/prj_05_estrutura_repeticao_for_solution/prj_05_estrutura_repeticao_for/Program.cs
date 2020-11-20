using System;

namespace prj_05_estrutura_repeticao_for
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<10; i++)
            {
                Console.Write("{0} x {1} = {2}", i, i, i*i);
            }
        }
    }
}
