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

            int i = 0;
            while (i < quant)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                int n1 = int.Parse(Console.ReadLine());
                vetor[i] = n1;

                Console.WriteLine("Quer digitar mais um número? (s/n)");
                Console.WriteLine($"Tamanho do vetor: {quant}");
                Console.WriteLine($"Números digitados: {i + 1}");

                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    if (i < quant - 1)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Você já atingiu o número máximo de entradas.");
                        break;
                    }
                }
                else if (resposta == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }

            Console.WriteLine($"A média é: {calc.CalcularMedia(vetor)}");
        }
    }
   
        public double CalcularMedia(int[] numeros)
        {
            int soma = 0;
            foreach (int num in numeros)
            {
                soma += num;
            }
            return (double)soma / numeros.Length;
        }
    }
