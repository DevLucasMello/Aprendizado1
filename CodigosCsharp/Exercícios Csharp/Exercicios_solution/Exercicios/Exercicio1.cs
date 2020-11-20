using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Exercicio1
    {
        //EXERCÍCIO 1
        //1° Delaração de variável
        public int n1, n2, aux, num;

        //2° Construtor
        public Exercicio1()
        {
            n1 = 10;
            n2 = 20;
            aux = 0;
            num = 0;            
        }//Fim do Método Construtor

        //Método Get/Set
        public int MudarN1
        {
            get
            {
                return n1;
            }
            set
            {
                n1 = value;
            }
        }//Fim do Get/Set MudarN1
        public int MudarN2
        {
            get
            {
                return n2;
            }
            set
            {
                n2 = value;
            }
        }//Fim do Get/Set MudarN2
        public int ReceberAux
        {
            get
            {
                return aux;
            }
            set
            {
                aux = value;
            }
        }//Fim do Get/Set ReceberAux

        //EXERCÍCIO 2
        public int AntecessorNum
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }//Fim do Método Get/Set AntecessorNum

        //EXERCÍCIO 1
        public void Trocar()
        {                        
            ReceberAux = MudarN1;
            MudarN1 = MudarN2;
            MudarN2 = ReceberAux;
            Console.WriteLine   ("O conteúdo de A é: "  + MudarN1 +
                                "\nO conteúdo de B é: " + MudarN2);
        }//Fim do Método Trocar

        //EXERCÍCIO 2
        public int Antecessor(int num)
        {
            AntecessorNum = num;
            return AntecessorNum-1;
        }//Fim do Método Antecessor
    }//Fim da Classe Exercicio1
}//Fim do Projeto
