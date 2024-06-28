
internal class Average
{
    public double CalcularMedia(int[] vetor)
    {
        double soma = 0;
        foreach (int num in vetor)
        {
            soma += num;
        }
        return soma / vetor.Length;
    }
}