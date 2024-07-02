
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Calculadora de Média");
                Console.Write("Digite a quantidade de números que quer calcular a média: ");
                int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());

                List<double> numeros = new List<double>();

                for (int i = 0; i < quantidadeNumeros; i++)
                {
                    Console.Write("Digite o número {0}: ", i + 1);
                    double numero = Convert.ToDouble(Console.ReadLine());
                    numeros.Add(numero);
                }

                double media = CalcularMedia(numeros);

                Console.WriteLine($"A média é: {media:F2}");
            } 

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

}
    

