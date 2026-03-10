namespace HanShu
{
    internal class Hanshu
    {

        static void Main(string[] args)
        {
            //int getNumber = Console.ReadKey().KeyChar - '0';
            //Console.WriteLine(Topic_4(getNumber));
            int getAge = int.Parse(Console.ReadLine());
            Console.WriteLine(Topic_5(getAge));
        }

        static bool Topic_4(int number)
        {
        
            for (int i = 2; i < number; i++)
            {
                
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool Topic_5(int number)
        {
            return number % 400 == 0 || number % 4 == 0 && number % 100 != 0 ? true : false;

        }
    }
}
