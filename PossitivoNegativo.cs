using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, 
//calcule a raiz quadrada; se for negativo, informe o número ao quadrado.

namespace DesafiodotNetVS
{
    internal class PossitivoNegativo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O numero digitado é positivo ou negativo");
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            double raizQuadrada = Math.Sqrt(numero);
            double quadrado = numero ^ 2;
            if (numero < 0)
            {
                Console.WriteLine("O quadrado do numero:"+ numero + " é " + quadrado);
            }
            else
            {
                Console.WriteLine("A raiz quadrada de: " + numero + " é " + raizQuadrada);
            }
        }
    }
}
