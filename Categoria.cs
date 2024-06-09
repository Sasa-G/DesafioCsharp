using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escreva um programa que leia o código de um produto e informe a sua categoria: 

1 a 10: Alimento não-perecível 

11 a 20: Alimento perecível 

21 a 30: Vestuário 

31 a 40: Eletrônicos 

Outros: Código inválido */

namespace DesafiodotNetVS
{
    internal class Categoria
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Categoria dos produtos");
            Console.WriteLine("Escreva o código");
            int codigo = Convert.ToInt32(Console.ReadLine());
            if (codigo >= 1 && codigo <= 10)
            {
                Console.WriteLine("Alimento não-perecível ");
            }
            else if(codigo >= 11 && codigo <= 20)
            {
                Console.WriteLine("Alimento perecível ");
            }
            else if(codigo >= 21 && codigo <= 30)
            {
                Console.WriteLine(" Vestuário ");
            }
            else if(codigo >= 31 && codigo <= 40)
            {
                Console.WriteLine("Eletrônicos ");
            }
            else
            {
                Console.WriteLine("Código inválido");
            }
        }
    }
}
