using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class Exercicio3_4
    {
        //EXERCÍCIO 3_4
        //Declaração das variáveis
        public double base1, altura1, area1;
        public int ano, mes, dia, idadeDias;

        //2° Método construtor
        public Exercicio3_4()
        {
            base1 = 0;
            altura1 = 0;
            area1 = 0;
            ano = 0;
            mes = 0;
            dia = 0;
            idadeDias = 0;
        }//Fim do Método Construtor

        //Criação do Get/Set
        public double AtribuirBase1
        {
            get
            {
                return base1;
            }
            set
            {
                base1 = value;
            }
        }//Fim do Get/Set AtribuirBase1
        public double AtribuirAltura1
        {
            get
            {
                return altura1;
            }
            set
            {
                altura1 = value;
            }
        }//Fim do Get/Set AtribuirAltura1
        public double CalcularArea
        {
            get
            {
                return area1;
            }
            set
            {
                area1 = value;
            }
        }//Fim do Get/Set CalcularArea

        //EXERCÍCIO 4
        public int ReceberAno
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }//Fim do Get/Set ReceberAno
        public int ReceberMes
        {
            get
            {
                return mes;
            }
            set
            {
                mes = value;
            }
        }//Fim do Get/Set ReceberMes
        public int ReceberDia
        {
            get
            {
                return dia;
            }
            set
            {
                dia = value;
            }
        }//Fim do Get/Set ReceberDia
        public int ExibirIdadeDias
        {
            get
            {
                return idadeDias;
            }
            set
            {
                idadeDias = value;
            }
        }//Fim do Get/Set ExibirIdadeDias
        
        //EXERCÍCIO 3
        //Método Cálcular Area
        public double Area(double base1, double altura1)
        {
            AtribuirBase1 = base1;
            AtribuirAltura1 = altura1;            
            CalcularArea = (AtribuirBase1 * AtribuirAltura1);
            return CalcularArea;
        }//Fim do Método Area

        //EXERCÍCIO 4
        //Método Calcular Idade em Dias
        public int Dias(int ano, int mes, int dia)
        {
            ReceberAno = ano;
            ReceberMes = mes;
            ReceberDia = dia;
            ExibirIdadeDias = ((ano * 365) + (mes * 30) + dia);
            return ExibirIdadeDias;
        }


    }//Fim da Classe Exercício3_4
}
