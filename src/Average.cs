namespace ConsoleApp1
{
    public class Average
    {
        public int CalcularMedia(int quant, int[] numbers) {
            int result = 0;
            foreach (var number in numbers) 
            {
                result += number;
            }
            
            return result / quant;


        }
    }
}