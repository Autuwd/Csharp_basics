namespace Variable
{
    enum E_QQType
    {
        Online,
        Leave,
        Invisibility,
    }

    enum E_Coffee
    {
        M,
        B,
        S,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Topic_1();
            Topic_2();
        }

        static void Topic_1()
        {
            Console.WriteLine("请选择一个状态：0-在线，1-离开，2-隐身");
            int onlineType = Console.ReadKey().KeyChar - '0' ;
            E_QQType qqType = (E_QQType)onlineType;
            Console.WriteLine();
            Console.WriteLine(onlineType);
            Console.WriteLine(qqType);
        }

        static void Topic_2()
        {
            Console.WriteLine("Chese your coffee: 0-M, 1-B, 2-S");
            int coffee = Console.ReadKey().KeyChar - '0';
            E_Coffee e_Coffee = (E_Coffee)coffee;
            Console.WriteLine(e_Coffee);
        }
    }
}
