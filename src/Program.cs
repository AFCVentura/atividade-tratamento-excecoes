
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");

            List<double> lista = new List<double>();
            int quant;

            while(true)
            {
                try
                {
                    while (true)
                    {
                        quant = int.Parse(Console.ReadLine());
                        if (quant <= 1)
                        {
                            Console.WriteLine("Digite um valor maior que 1");
                        }
                        else
                        {
                            break;
                        }
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um valor válido");
                }

            }


            for (int i = 0; i >= 0; i++) {

                double n1;

                Console.Write($"Digite o {i+1}º número: ");
                while(true)
                {
                    try
                    {
                        n1 = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor válido");
                    }
                }
                lista.Add(n1);
                Console.WriteLine();
                

                if (lista.Count > quant)
                {
                    quant++;
                }

                System.Console.WriteLine($"Tamanho do vetor: {quant}");
                System.Console.WriteLine($"Números digitados: {i + 1}");
                Console.WriteLine();

                if (lista.Count == quant)
                {
                    string resposta;

                    while(true)
                    {

                        System.Console.Write("Quer digitar mais um número? (s/n): ");
                        resposta = Console.ReadLine();
                        Console.WriteLine();
                        if (resposta.ToUpper() == "S")
                        {
                            break;
                        }
                        else if (resposta.ToUpper() == "N")
                        {
                            break;
                        }
                        else
                        {
                            System.Console.WriteLine("Digite um valor válido");
                            continue;
                        }
                    }
                if (resposta.ToUpper() == "S")
                    {
                        continue;
                    }
                else
                    {
                        break;
                    }
                }

            }
            Console.WriteLine("A média dos números digitados é igual a: " + calc.CalcularMedia(quant, lista));
            
        }
    }
}
