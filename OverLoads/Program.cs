namespace OverLoads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CompareSize(1, 2));
            //Console.WriteLine(CompareSize(1.0f, 2.0f));
            //Console.WriteLine(CompareSize(1.0, 2.0));
            Console.WriteLine(CompareSizes(1, 2, 3, 4));
            Console.WriteLine(CompareSizes(1.0f , 2.0f, 3.0f, 4.0f));
            Console.WriteLine(CompareSizes(1.0 , 2.0, 3.0, 4.0));
        }

        static int CompareSize(int a, int b)
        {
            return a > b ? a : b;
        }
        static float CompareSize(float a, float b)
        {
            return a > b ? a : b;
        }
        static double CompareSize(double a, double b)
        {
            return a > b ? a : b;
        }


        static int CompareSizes(params  int[] numbers)
        {
            int max = 0;
            for(int i  = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
        static float CompareSizes(params  float[] numbers)
        {
            float max = 0;
            for(int i  = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
        static double CompareSizes(params  double[] numbers)
        {
            double max = 0;
            for(int i  = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                    max = numbers[i];
            }
            return max;
        }
    }
}
