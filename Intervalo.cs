using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive). 

namespace DesafiodotNetVS
{
    internal class Intervalo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Está em um intervalo de 10 a 20?");
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("O numero " + numero + " se encontra no intervalo de 10 a 20");
            }
            else
            {
                Console.WriteLine("O numero " + numero + " NÃO se encontra no intervalo de 10 a 20");
            }
        }
    }
}
