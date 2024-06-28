namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");

            int quant;
            while (true)
            {
                try
                {
                    quant = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Você deve digitar um número inteiro. Tente novamente!");
                }
            }

            int[] vetor = new int[quant];
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número: ");
                int n1;
                while (true)
                {
                    try
                    {
                        n1 = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Você deve digitar um número inteiro. Tente novamente!");
                    }
                }
                vetor[i] = n1;
            }

            Console.WriteLine("Você deseja calcular a média com esses números? (s/n)");
            string resposta;
            while (true)
            {
                resposta = Console.ReadLine().ToUpper();
                if (resposta == "S" || resposta == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Erro: Você deve digitar 'S' ou 'N'. Tente novamente!");
                }
            }

            if (resposta == "S")
            {
                Console.WriteLine($"Media: {calc.CalcularMedia(vetor)}");
            }
            else
            {
                Console.WriteLine("Ok, vamos começar novamente!");
                Main(args);
            }
        }
    }
}