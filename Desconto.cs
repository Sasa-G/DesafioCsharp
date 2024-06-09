using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escreva um programa que leia o valor de uma compra e a categoria do cliente
(1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: 

Comum: Sem desconto

Associado: 10 % de desconto

VIP: 20 % de desconto

Informe o valor final da compra. */

namespace DesafiodotNetVS
{
    internal class Desconto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("leia o valor de uma compra e a categoria do cliente");
            Console.WriteLine(" ");
            Console.WriteLine("Digite 1 para comum, 2 para associado e 3 para VIP ");
            string? Escolha = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Digite o valor da sua compra");
            double valor = Convert.ToDouble(Console.ReadLine());
            
            
            switch (valor){
                case 1:
                    Console.WriteLine("Não possui descontos, valor: R$ " + valor);
                    break;

                case 2:
                    Console.WriteLine("O valor de desconto de 10% fica: R$ " + (valor - (valor * 0.1)));
                    break;
                case 3:
                    Console.WriteLine("O valor do desconto de 20% fica: R$ " + (valor - (valor * 0.5)));
                    break;
                default:
                    Console.WriteLine("Valor digitado não corresponde");
                    break;
            }
        }
    }
}



