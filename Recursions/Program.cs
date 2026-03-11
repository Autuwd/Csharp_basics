namespace Recursions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //PrintNumber(10);
            //Console.WriteLine(Factorial(5));
            //Console.WriteLine(FactorialAdd(5));
            //Console.WriteLine(Bamboo(10));
            Print(200);
        }

        static void  PrintNumber(int  number)
        {
            if (number < 0)
            {
                return;
            }
            Console.WriteLine(number);
            PrintNumber(number - 1);
        }

        static int Factorial(int number)
        {
            return number == 1 ? number : number * Factorial(number - 1);
        }

        static int FactorialAdd(int numberMax)
        {
            int sum = Factorial(numberMax);
            return numberMax == 1 ? numberMax : sum += FactorialAdd(numberMax - 1);
        }

        static double Bamboo(int counts, double bambooSize = 100)
        {
            
            if(counts == 0)
            {
                return bambooSize;
            }
            return Bamboo(counts - 1, bambooSize / 2);
        }

        static bool Print(int num)
        {
            Console.WriteLine(num);
            return num == 1 || Print(num - 1);
        }
    }
}
