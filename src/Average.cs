namespace ConsoleApp1
{
    public class Average
    {
        public double CalcularMedia(int quant, List<double> numbers) {
            double result = 0;
            foreach (var number in numbers) 
            {
                result += number;
            }
            
            return result / quant;
        }
    }
}