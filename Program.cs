using System;
using System.Collections.Generic;

namespace AulasPCDev
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            bool continuar = true;
            do
            {
                Console.WriteLine("Bem vindo ao meu programa");
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("A - Somar");
                Console.WriteLine("B - Subtrair");
                Console.WriteLine("0 - Sair do programa");
                Console.WriteLine("Digite o letra da opção selecionada");

                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Digite o primeiro valor");
                        int a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o segundo valor:");
                        int b = int.Parse(Console.ReadLine());

                        int resultado = Adicionar(a, b);

                        Console.WriteLine("O resultado é: " + resultado);
                        break;
                    case "B":
                    case "b":
                        int resulta = Subtrair(5, 3);
                        break;
                    case "0":
                    default:
                        continuar = false;
                        break;
                }
            } while (continuar);
        }

        static int Adicionar(int a, int b)
        {
            int soma = a + b;
            return soma;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}
