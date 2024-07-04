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

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                int n1 = int.Parse(Console.ReadLine());
                vetor[count] = n1;


                if (i < quant - 1)
                {
                    Console.WriteLine("Quer digitar mais um número? (s/n)");
                    string resposta = Console.ReadLine().ToUpper();

                    if (resposta == "S")
                    {
                        continue;
                    }
                    else if (resposta == "N")
                    {
                        Array.Resize(ref vetor, i + 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido (s/n)");
                        i--; // Decrementa i para repetir a entrada
                    }
                }
            }

            Console.WriteLine($"a média é: {calc.CalcularMedia(vetor)}");
        }
    }
}