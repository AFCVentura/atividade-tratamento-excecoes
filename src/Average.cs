namespace ConsoleApp1
{
    public class Average
    {
        public double CalcularMedia(int[] numbers)
        {
            int result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }

            return numbers.Length > 0 ? (double)result / numbers.Length : 0;
        }
    }
}