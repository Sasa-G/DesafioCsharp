using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 

Abaixo do peso: IMC < 18.5 

Peso normal: 18.5 <= IMC < 24.9 

Sobrepeso: 25 <= IMC < 29.9 

Obesidade grau I: 30 <= IMC < 34.9 

Obesidade grau II: 35 <= IMC < 39.9 

Obesidade grau III: IMC >= 40 */

namespace DesafiodotNetVS
{
    internal interface IMC
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("calculo do IMC e informe a categoria");
            Console.WriteLine(" ");

            Console.WriteLine("Digite sua altura, ultilize ',' como separado. Exemplo: 1,75");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Digite seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            double IMC = peso / (altura * altura);
            Console.WriteLine(IMC);

            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (IMC <= 24.9 && IMC >= 18.5)
            {
                Console.WriteLine("Peso normal");
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                Console.WriteLine(" Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }





        }
    }
}
 