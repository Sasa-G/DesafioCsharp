using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que leia um número e 
// verifique se ele é maior que 100. Se não for, informe o dobro desse número.

namespace DesafiodotNetVS
{
    internal class DobroOuMaior
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("verifique se ele é maior que 100. Se não for, informe o dobro desse número");
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 100)
            {
                Console.WriteLine("O numero " + numero + " é maior que 100");
            }
            else
            {
                Console.WriteLine("O numero " + numero + " é menor que 100 e seu dobro é: " + numero * 2);
            }
        }
    }
}
