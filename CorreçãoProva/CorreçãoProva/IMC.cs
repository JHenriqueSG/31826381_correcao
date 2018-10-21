using System;
using System.Collections.Generic;
using System.Text;

namespace CorreçãoProva
{
    class IMC    // classe atributos privados
    {
        private double peso;
        private double altura;

        /*public IMC()  // metodo construtor padrão
        {
            this.peso = 0.0;
            this.altura = 0.0;

        }*/

        public IMC(double peso, double altura)    // segunda variação usuario passa pesso a altura
        {
            this.peso = peso;
            this.altura = altura;

        }


        public double Calcular(double peso, double altura)      //metodo Calcular
        {
            return peso / (altura * altura);

        }

        public string Classificar(double imc)
        {
            
                if (imc > 40.0)
                {
                    Console.WriteLine(" Obesidade grau 3 ");

                }
                else 
                
                if (imc < 40.0 && imc >= 35.0)
                {
                    Console.WriteLine(" Obesidade grau 2 ");
                }
                else 
                
                if (imc >= 30.0 && imc < 35.0)
                {
                    Console.WriteLine(" Obesidade grau 1 ");
                }
                else 
                
                if (imc >= 25.0 && imc < 30.0)
                {

                    Console.WriteLine(" Sobrepeso ");
                }
                else 
                
                if (imc >= 18.5 && imc < 25.0)
                {
                    Console.WriteLine(" Saudavel ");
                }
                else
                
                if (imc >= 17.0 && imc < 18.6)
                {
                    Console.WriteLine(" Magreza Leve ");
                }
                else
                
                if (imc >= 16.0 && imc < 17.0)
                {
                    Console.WriteLine(" Magreza moderada ");
                }
                else 
                
                if (imc < 16.0 && imc > 0)
                {
                    Console.WriteLine(" Magreza grave ");
                    
                }
             


            return Classificar(imc);

        }
    }
}
