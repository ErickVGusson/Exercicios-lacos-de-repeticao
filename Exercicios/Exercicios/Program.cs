using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ______     __  __     ______     ______     ______     __     ______     __     ______     ______    \r\n/\\  ___\\   /\\_\\_\\_\\   /\\  ___\\   /\\  == \\   /\\  ___\\   /\\ \\   /\\  ___\\   /\\ \\   /\\  __ \\   /\\  ___\\   \r\n\\ \\  __\\   \\/_/\\_\\/_  \\ \\  __\\   \\ \\  __<   \\ \\ \\____  \\ \\ \\  \\ \\ \\____  \\ \\ \\  \\ \\ \\/\\ \\  \\ \\___  \\  \r\n \\ \\_____\\   /\\_\\/\\_\\  \\ \\_____\\  \\ \\_\\ \\_\\  \\ \\_____\\  \\ \\_\\  \\ \\_____\\  \\ \\_\\  \\ \\_____\\  \\/\\_____\\ \r\n  \\/_____/   \\/_/\\/_/   \\/_____/   \\/_/ /_/   \\/_____/   \\/_/   \\/_____/   \\/_/   \\/_____/   \\/_____/ \r\n                                                                                                      \n\n");
            Console.ResetColor();

            Console.WriteLine("Exercício 1 - Números Pares em um intervalo");
            Console.WriteLine("Exercício 2 - Sequência de Fibonacci");
            Console.WriteLine("Exercício 3 - Números Primos no intervalo");
            Console.Write("Digite a função desejada: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int menu = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            switch (menu)
            {

                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" ____ ____ ____ ____ ____ \r\n||P |||a |||r |||e |||s ||\r\n||__|||__|||__|||__|||__||\r\n|/__\\|/__\\|/__\\|/__\\|/__\\|\n\n");
                    Console.ResetColor();

                    Console.Write("Digite o número do início: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int numeroInicio = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Digite o número do final: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int numeroFim = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    int numerosPares = 0;
                    for (int i = numeroInicio; i <= numeroFim; i++)
                    {


                        if (i % 2 == 0)
                        {

                            numerosPares++;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(i);
                            Console.ResetColor();

                        }

                        else
                        {

                            //Console.WriteLine(i);

                        }

                    }

                    Console.WriteLine("\n\nHá um total de " + numerosPares + " números pares");
                    break;

                case 2:

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" ____ ____ ____ ____ ____ ____ ____ ____ ____ \r\n||F |||i |||b |||o |||n |||a |||c |||c |||i ||\r\n||__|||__|||__|||__|||__|||__|||__|||__|||__||\r\n|/__\\|/__\\|/__\\|/__\\|/__\\|/__\\|/__\\|/__\\|/__\\|\n\n");
                    Console.ResetColor();

                    Console.Write("Bem vindos a sequência de Fibonacci, digite a posição que deseja ver: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int quantidade = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    double numeroAtual = 1;
                    double numeroAnterior = 0;
                    double temporario = 1;

                    for (int i = 1; i <= quantidade; i++)
                    {

                        Console.Write("Posição " + i + "º: ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(numeroAtual);
                        Console.ResetColor();

                        temporario = numeroAnterior;
                        numeroAnterior = numeroAtual;
                        numeroAtual = temporario + numeroAtual;

                    }

                    break;

                case 3:

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" ____ ____ ____ ____ ____ ____ \r\n||P |||r |||i |||m |||o |||s ||\r\n||__|||__|||__|||__|||__|||__||\r\n|/__\\|/__\\|/__\\|/__\\|/__\\|/__\\|\n\n");
                    Console.ResetColor();

                    Console.Write("Digite o número do início: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int inicio = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Digite o número do final: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int fim = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    int contaPrimo = 0;

                    for (int i = inicio; i <= fim; i++)
                    {
                        int divisores = 0;

                        if (i > 0)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    divisores++;

                                }
                            }

                            if (divisores == 2)
                            {

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(i);
                                Console.ResetColor();
                                Console.WriteLine(" É primo");
                                contaPrimo++;

                            }

                            else
                            {
                                Console.WriteLine(i + " não é primo");
                            }

                            Console.WriteLine("Divisores: " + divisores + "\n");
                        }

                        else
                        {

                            Console.WriteLine(i + " É um número negativo, sendo assim não pode ser considerado primo");

                        }

                    }

                    Console.Write("\nHá um total de ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(contaPrimo);
                    Console.ResetColor();
                    Console.WriteLine(" de números primos");

                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" \n                    /´¯/) \r\n                   ,/¯  / \r\n                  /    / \r\n            /´¯`/'   '/´¯¯`·¸ \r\n         /'/    /    /    /¨  /¯\\ \r\n        ('(    ´    ´     ¯˜/'   ') \r\n         \\                 '     / \r\n          '\\'   \\           _.·´ \r\n            \\              ( \r\n              \\             \\");
                    break;

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
