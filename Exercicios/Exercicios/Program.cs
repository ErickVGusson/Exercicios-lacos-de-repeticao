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

                    Console.Write("Bem vindos a sequência de Fibonacci, digite quantas vezes deseja que a operação seja concluida: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int quantidade = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    double numeroAtual = 1;
                    double numeroAnterior = 0;
                    double fibonacci = 0;

                    for (int i = 1; i <= quantidade; i++)
                    {

                        fibonacci = numeroAtual + numeroAnterior;
                        Console.Write(numeroAnterior + " + " + numeroAtual + " = ");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(fibonacci);
                        Console.ResetColor();
                        numeroAnterior = numeroAtual;
                        numeroAtual = fibonacci;

                    }

                    break;

               case 3: //  a completar

                    Console.Write("Digite o número do início: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int inicio = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    Console.Write("Digite o número do final: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    int fim = int.Parse(Console.ReadLine());
                    Console.ResetColor();

                    int contaPrimo = 0;
                    int divisores = 0;
                    for (int i = inicio; i <= fim; i++)
                    {

                        if (i > 0)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                if (i % j == 0)
                                {
                                    divisores++;
                                }
                            }

                        }

                        else
                        {

                            Console.WriteLine(i + " É um número negativo, sendo assim não pode ser considerado primo");

                        }


                    }

                    break;
            }








            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
