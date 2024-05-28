using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Insira a operação(+ - / *): ");
            string operacao = (Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    soma(n1, n2);
                    Console.Write("O resultado é: " + soma(n1, n2));
                    Console.ReadKey();
                    break;

                case "-":
                    subtracao(n1, n2);
                    Console.Write("O resultado é: " + subtracao(n1, n2));
                    Console.ReadKey();
                    break;

                case "/":
                    divisao(n1, n2);
                    Console.Write("O resultado é: " + divisao(n1, n2));
                    Console.ReadKey();
                    break;

                case "*":
                    multiplicacao(n1, n2);
                    Console.Write("O resultado é: " + multiplicacao(n1, n2));
                    Console.ReadKey();
                    break;
            }
        }

        static double soma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }

        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}