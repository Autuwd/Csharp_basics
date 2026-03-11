namespace VariableParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MultiNumberAdd(1, 2, 3, 4, 5));
            MultiNumbers(1, 2, 3, 4, 5, 6);
        }

        static int MultiNumberAdd(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void MultiNumbers(params int[] numbers)
        {
            int sum_1 = 0;
            int sum_2 = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum_1 += num;
                }
                else
                {
                    sum_2 += num;
                }                       
            }
            Console.WriteLine(sum_1);
            Console.WriteLine(sum_2);
        }
    }
}
