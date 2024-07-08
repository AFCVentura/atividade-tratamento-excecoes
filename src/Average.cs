public class Average
{
    public double CalcularMedia(int quant, int[] numbers)
    {
        if (quant <= 0 || numbers == null || numbers.Length < quant)
        {
            throw new ArgumentException("Quantidade inválida ou array de números inválido.");
        }

        int result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }

        return (double)result / quant;
    }
}