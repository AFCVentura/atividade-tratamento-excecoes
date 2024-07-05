namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Average calc = new Average();
                    Console.WriteLine("Você quer calcular a média de quantos números?");
                    int quant = int.Parse(Console.ReadLine());

                    if (quant <= 0)
                    {
                        Console.WriteLine("A quantidade de números deve ser maior que zero.");
                    }

                    int[] vetor = new int[quant];

                    for (int i = 0; i < quant; i++)
                    {
                        Console.WriteLine($"Digite o {i + 1}º número: ");
                        vetor[i] = int.Parse(Console.ReadLine());
                    }

                    double media = calc.CalcularMedia(quant, vetor);
                    Console.WriteLine("A média é: " + media);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                }


                Console.WriteLine("Deseja calcular a média de outro conjunto de números? (s/n)");
                if (Console.ReadLine().ToUpper() != "S")
                {
                    break;
                }
            }

        }
    }