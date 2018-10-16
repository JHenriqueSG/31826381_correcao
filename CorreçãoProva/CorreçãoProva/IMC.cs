using System;
using System.Collections.Generic;
using System.Text;

namespace CorreçãoProva
{
    class IMC    // classe atributos privados
    {
        private double peso;
        private double altura;

        public IMC()  // metodo construtor padrão
        {
            this.peso = 0.0;
            this.altura = 0.0;

        }

        public IMC(double peso, double altura)    // segunda variação usuario passa pesso a altura
        {
            this.peso = peso;
            this.altura = altura;

        }


        public double Calcular(double peso, double altura)      //metodo Calcular
        {
            return peso / (altura * altura);

        }

        public double classificar(double imc)
        {
            return 0.0;
        }
    }
}
