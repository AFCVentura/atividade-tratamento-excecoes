
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

            try
            {
                for (int i = 0; i < quant; i++)
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
                        continue;
                    }
                    else if (resposta == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor válido (s/n)");
                        i--; 
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido. Digite um número inteiro.");
            }

            Console.WriteLine($"A média é: {calc.CalcularMedia(quant, vetor)}");
        }
    }

}
    

