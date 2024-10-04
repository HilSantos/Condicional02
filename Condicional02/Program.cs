using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional02
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Objetivo: Receber um valor de camiseta e a sua cor para compra.
             * Receber também a quantidade de camisetas, efetuar o calculo (total=valor*quantidade), e analisar os valores:
             * Se total>=250 (ofertar desconto de 2%), caso contrario (total não sofrerá alteração).
            */
            string cor;
            double valCamiseta, Quantidade, Total;

            Console.WriteLine("Informe a cor da camiseta: ");
            cor = Console.ReadLine();

            Console.WriteLine("Digite o valor da camiseta: ");
            valCamiseta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade: ");
            Quantidade = Convert.ToDouble(Console.ReadLine());

            Total = valCamiseta * Quantidade;

            if (Total >= 250)
            {
                Total = Total - (Total * 2) / 100;
                Console.WriteLine("Total com 2% Desconto: "+Total.ToString("C"));
            }
            else
            {
                Console.WriteLine("Total a pagar: "+Total.ToString("C"));
            }
            Console.ReadKey();
        }
    }
}
