using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Escreva um programa que leia a idade de uma pessoa e informe se ela é uma
// criança (0-12 anos), adolescente (13-17 anos),adulto (18-59 anos) ou idoso (60 anos ou mais).

namespace DesafiodotNetVS
{
    internal class Idade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Identificador: criança, adolescente adulto ou idoso?");
            Console.WriteLine("Digite uma idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade <=12 && idade >= 0)
            {
                Console.WriteLine("é uma criança");
            }
            else if (idade <= 17 && idade >= 13)
            {
                Console.WriteLine("é um adolescente");
            }
            else if (idade <= 59 && idade >= 18)
            {
                Console.WriteLine("É Uum adulto");
            }
            else
            {
                Console.WriteLine("é um idoso");
            }
        }
        

    }
}
