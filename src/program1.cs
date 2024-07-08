
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");
            int quant = int.Parse(Console.ReadLine());
            int[] vetor = new int[quant];

            for (int i = 0; i < vetor.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    vetor[i] = n1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado.");
                    break;
                }
            }

            System.Console.WriteLine("Quer digitar mais um número? (s/n)");
                System.Console.WriteLine($"Tamanho do vetor: {quant}");
                System.Console.WriteLine($"Números digitados: {i + 1}");

                if (Console.ReadLine().ToUpper() == "S") {
                    continue;
                }
                else if (Console.ReadLine().ToUpper() == "N") {
                    break;
                }
                else {
                    System.Console.WriteLine("Digite um valor válido");
                    continue;
                }
            }
            Console.WriteLine(calc.CalcularMedia(quant, vetor));
            
        }
    }
}
