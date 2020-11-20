using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculo
    {
        //1° Declaração de variável
        public double num1, num2;
        
        //2° Construtor
        public Calculo()
        {
            num1 = 0;
            num2 = 0;
        }//Fim do Construtor

        //Método Get/Set
        public double AlterarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                num1 = value;
            }
        }//Fim do Método Get/Set AlterarNum1
        public double AlterarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                num2 = value;
            }
        }//Fim do Método Get/Set AlterarNum2

        public double Somar(double num1, double num2)
        {
            AlterarNum1 = num1;
            AlterarNum2 = num2;
            return AlterarNum1 + AlterarNum2;
        }//Fim do Método Soma

        public double Subtrair(double num1, double num2)
        {
            AlterarNum1 = num1;
            AlterarNum2 = num2;
            return AlterarNum1 - AlterarNum2;
        }//Fim do Método Subtrair

        public double Multiplicar(double num1, double num2)
        {
            AlterarNum1 = num1;
            AlterarNum2 = num2;
            return AlterarNum1 * AlterarNum2;
        }//Fim do Método Multiplicar

        public double Dividir(double num1, double num2)
        {
            AlterarNum1 = num1;
            AlterarNum2 = num2;

            if (AlterarNum2 == 0)
            {
                return -1;
            }
            return AlterarNum1 / AlterarNum2;
        }//Fim do Método Dividir
    }//Fim da Classe Cálculo
}//Fim do Projeto
