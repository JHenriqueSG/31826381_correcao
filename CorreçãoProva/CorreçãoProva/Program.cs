using System;

namespace CorreçãoProva
{
    class Program
    {
        static void Main(string[] args)
        {

            
            static int Maior(int a, int b)
             {
                if(a > b)
                    return a;
                else
                    return b;
            }

          

            

            /*
              1. Implemente o método Maior(a, b) que recebe dois números inteiros como parâmetro
              e retorna qual deles é o maior.
             */

            int a,
                b;

            Console.WriteLine("insira um numero");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo valor");
            b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " é maior que " + b);
            }

            else
            {
                Console.WriteLine(b + " é maior que " + a);
            }

            Console.ReadKey(true);





        }

        /*2. O índice de massa corporal (IMC) é uma medida internacional usada para calcular se uma
          pessoa está no peso ideal. Ele é determinado pela divisão da massa do indivíduo pelo
          quadrado de sua altura, em que a massa está em quilogramas e a altura em metros.*/







        /*3. Se o resto da divisão de um número inteiro por 2 for zero, então, o número é par, caso
        contrário, é ímpar. Implemente a função lógica Par(numero) que retorna verdadeiro caso o
        número passado como parâmetro seja par ou falso caso ele seja ímpar.*/

        static bool Par(int numero)
        {
            int resto = numero % 2;

            if (resto == 0)
                return true;

            else
                return false;


        }
        static string Par2(int numero)
        {
            int resto = numero % 2;
            if (resto == 0)
                return "par";
            else
                return "ímpar";
            Console.ReadKey(true);

        }

        /**/





    }




}
