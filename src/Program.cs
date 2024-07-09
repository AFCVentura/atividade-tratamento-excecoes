
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");
            int quant = int.Parse(Console.ReadLine());
            
            try {
                quant = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex) 
            {
                Console.WriteLine("Erro! A entrada é Inválida para a quantidade de números. Por favor, mude para um número inteiro!")
                return;
            }

            int[] vetor = new int [quant];

            for (int i = 0; i >= 0; i++)
            {
                 Console.WriteLine($"Digite o {i + 1}º número: ");
                        int n1 = int.Parse(Console.ReadLine());
                        vetor[i] = n1;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Erro! Formato de número inválido. Por favor, insira um número inteiro.");
                        continue;
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Erro! Índice fora do intervalo do vetor.");
                        break;
                    }

                    System.WriteLine("Quer digitar mais um número? (s/n)");
                    System.WriteLine($"Tamanho do vetor: {quant}");
                    System.WriteLine($"Números digitados: {i + 1}");

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
                        Console.WriteLine("Digite um valor válido");
                        continue;
                    }
                }

                try
                {
                    Console.WriteLine(calc.CalcularMedia(quant, vetor));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao calcular a média: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

    class Average
    { 
        public int CalcularMedia(int quant, int[] numbers) 
        {
            int result = 0;
            foreach (var number in numbers) 
            {
                result += number;
            }
            
            return result / quant;
        }
    }

