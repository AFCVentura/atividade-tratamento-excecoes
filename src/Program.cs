
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
                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    vetor[i] = n1;

                    System.Console.WriteLine("Quer digitar mais um número? (s/n)");
                    System.Console.WriteLine($"Tamanho do vetor: {quant}");
                    System.Console.WriteLine($"Números digitados: {i + 1}");

                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        continue;
                    }
                    else if (Console.ReadLine().ToUpper() == "N")
                    {
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Digite um valor válido");
                        continue;
                    }
                }
       
            Console.WriteLine(calc.CalcularMedia(quant, vetor));
            }
            //Tratamento do tamanho da array
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("O número precisa ser igual ou maior que 2, seu burro!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
