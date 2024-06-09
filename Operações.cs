using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escreva um programa que leia dois números e uma operação
//(adição, subtração, multiplicação ou divisão) e realize a operação correspondente.

namespace DesafiodotNetVS
{
    internal class Operações
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação e realize a operação");

            Console.WriteLine("Digite o primeiro valor");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma operação: '+' = adição; '-' = Subtração; '/' = Divisão; '*' = multiplicação ");
            string Operador = Console.ReadLine();
            if (Operador == "+")
            {
                Console.WriteLine(numero1 + numero2);
            }
            else if (Operador == "-")
            {
                Console.WriteLine(numero1 - numero2);
            }
            else if (Operador == "/")
            {
                Console.WriteLine(numero1 / numero2);
            }
            else
            {
                Console.WriteLine(numero1 * numero2);
            }
        }
    }
}
