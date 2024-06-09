using System;

class ImparPar{
    public static void Main(string[]args){
        Console.Write("O numero selecionado é impar o par?");
        Console.Write("Insira um numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        if (numero1 / 2 == 0){
            Console.Write("O numero " + numero1 + "é PAR");
        }
        else{
             Console.Write("O numero " + numero1 + "é IMPAR");
        }

    }
}