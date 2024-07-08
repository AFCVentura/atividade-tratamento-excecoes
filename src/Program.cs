
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
              Average calc = new Average();
              Console.WriteLine("Você quer calcular a média de quantos números?");
              int quant = int.Parse(Console.ReadLine());
              int[] vetor = new int[quant];

                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    vetor[i] = n1;

                    System.Console.WriteLine("Quer digitar mais um número? (s/n)");
                    System.Console.WriteLine($"Tamanho do vetor: {quant}");
                    System.Console.WriteLine($"Números digitados: {i + 1}");

                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "S")
                    {
                        continue;
                    }
                    else if (resposta.ToUpper() == "N")
                    {
                        Console.WriteLine(calc.CalcularMedia(quant, vetor));
                        break;
                    }

                    else
                    {
                        System.Console.WriteLine("Digite um valor válido");
                        continue;
                    }
                }
       
            }
            //Tratamento do tamanho da array
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("O número precisa ser igual ou maior que 2, seu burro!");
                Console.WriteLine(ex.Message);
            }
            //Tratamento de entrada de dados que não são números
            catch (FormatException ex)
            {
                Console.WriteLine("Você digitou um caractere não esperado, digite apenas números!");
                Console.WriteLine("Erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Voce digitou um numero muito grande");
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
