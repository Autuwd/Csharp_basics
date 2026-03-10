namespace Input
{
    internal class Input
    {
        static void Main(string[] args)
        {
            //题目2
            //Topic_2();

            //题目3
            //Topic_3();

            //题目4
            Topic_4();
        }

        static void Topic_2()
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("请输入班级：");
            string classes = Console.ReadLine();
            Console.WriteLine(userName + age + classes);
        }

        static void Topic_3()
        {
            Console.WriteLine("你喜欢什么运动?");
            Console.ReadLine();
            Console.WriteLine("哈哈好巧，我也是");
        }

        static void Topic_4()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i == 9)
                {
                    Console.WriteLine("**********");
                }
                else
                {
                    Console.WriteLine("*        *");
                }
            }
        }
    }
}
