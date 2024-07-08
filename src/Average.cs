public class Average
{
    public double CalcularMedia(int quant, int[] numbers)
    {
        if (quant <= 0 || numbers == null || numbers.Length < quant)
        {
            throw new ArgumentException("Quantidade inv�lida ou array de n�meros inv�lido.");
        }

        int result = 0;
        foreach (int number in numbers)
        {
            result += number;
        }

        return (double)result / quant;
    }
}