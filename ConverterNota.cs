using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escreva um programa que leia a nota de um aluno e converta-a para conceito: 
 A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). */

namespace DesafiodotNetVS
{
    internal class ConverterNota
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("leia a nota de um aluno e converta-a para conceito");
            Console.WriteLine("Digite uma nota");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota >= 9)
            {
                Console.WriteLine("Nota: A");
            }
            else if (nota == 7 && nota < 9)
            {
                Console.WriteLine("Nota: B");
            }
            else if (nota == 5 && nota < 7)
            {
                Console.WriteLine("Nota: C");
            }
            else if (nota == 3 && nota < 5)
            {
                Console.WriteLine("Nota: D");
            }
            else
            {
                Console.WriteLine("Nota: F");
            }
        }
    }
}
