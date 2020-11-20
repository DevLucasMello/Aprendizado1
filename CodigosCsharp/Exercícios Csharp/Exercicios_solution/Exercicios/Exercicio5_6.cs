using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Exercicio5_6
    {
        //Declaração das variáveis
        public int eleitores, brancos, nulos, validos, percentual1, percentual2, percentual3, sm;

        //2° Construtores
        public Exercicio5_6()
        {
            eleitores = 0;
            brancos = 0;
            nulos = 0;
            validos = 0;
            percentual1 = 0;
            sm = 0;
        }//Fim do Método Construtor

        //3° Métodos Gets/Sets
        public int TotEleitores
        {
            get
            {
                return eleitores;
            }
            set
            {
                eleitores = value;
            }
        }//Fim do Get/Set TotEleitores
        public int TotBrancos
        {
            get
            {
                return brancos;
            }
            set
            {
                brancos = value;
            }
        }//Fim do Get/Set TotBrancos
        public int TotNulos
        {
            get
            {
                return nulos;
            }
            set
            {
                nulos = value;
            }
        }//Fim do Get/Set TotNulos
        public int TotValidos
        {
            get
            {
                return validos;
            }
            set
            {
                validos = value;
            }
        }//Fim do Get/Set TotValidos        
        public int TotalSm
        {
            get
            {
                return sm;
            }
            set
            {
                sm = value;
            }
        }//Fim do Get/Set TotalSm

        //4° Método de Cálculos
        public void Somatoria(int brancos, int nulos, int validos, int eleitores)
        {
            TotEleitores = eleitores;
            TotBrancos = brancos;
            TotNulos = nulos;
            TotValidos = validos;
            TotalSm = TotBrancos + TotNulos + TotValidos;
            percentual1 = (TotBrancos * 100) / TotalSm;
            percentual2 = (TotNulos * 100) / TotalSm;
            percentual2 = (TotValidos * 100) / TotalSm;
        }

    }//Fim da Classe Exercício 5_6
}//Fim do Projeto
