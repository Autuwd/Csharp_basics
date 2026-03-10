namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 学习ref和out的原因
            //学习ref和out的原因
            //它们可以解决 在函数内部改变外部传入的内容 里面变了 外面也要变

            static void ChangeValue(int value)
            {
                value = 3;
            }

            static void ChangeArrayValue(int[] arr)
            {
                arr[0] = 99;
            }

            static void ChangeArray(int[] arr)
            {
                //重新申明了一个 数组
                arr = new int[] { 10, 20, 30 };
            }

            #endregion

            #region 知识点二 ref和out的使用
            //函数参数的修饰符
            //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新申明时
            //外部的值会发生变化

            //ref
            static void ChangeValueRef(ref int value)
            {
                //out传入的变量必须在内部赋值 ref不用
                value = 3;
            }

            static void ChangeArrayRef(ref int[] arr)
            {
                arr = new int[] { 100, 200, 300 };
            }

            //out
            static void ChangeValueOut(out int value)
            {
                //out传入的变量必须在内部赋值 ref不用
                value = 99;
            }

            static void ChangeArrayOut(out int[] arr)
            {
                arr = new int[] { 999, 888, 777 };
            }

            #endregion

            #region 知识点三 ref和out的区别
            //1.ref传入的变量必须初始化  out不用
            //2.out传入的变量必须在内部赋值  ref不用

            // ref传入的变量必须初始化 但是在内部 可改可不改
            // out传入的变量不用初始化 但是在内部 必须修改该值（必须赋值）
            #endregion


            //总结
            //1.ref和out的作用 ： 解决值类型和引用类型 在函数内部 改值 或者 重新申明 能够影响外部传入的变量 让其也被修改
            //2.使用上：就是在申明参数的时候 前面加上 ref和out的 关键字即可 使用时 同上
            //3.区别
            // ref传入的变量必须初始化 但是在内部 可改可不改
            // out传入的变量不用初始化 但是在内部 必须修改该值（必须赋值）

            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string passWord = Console.ReadLine();
            //string info = "";

            //while (!CheckLogin(name, passWord, ref info))
            //{
            //    Console.WriteLine(info);
            //    Console.WriteLine("请输入用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();
            //}
            //Console.WriteLine(info);

            double radiusValue = 3.92781;
            //Calculate the circumference and area of a circle, returning the results to Main().
            CalculateCircumferenceAndArea(radiusValue, out double circumferenceResult, out var areaResult);
            System.Console.WriteLine($"Circumference of a circle with a radius of {radiusValue} is {circumferenceResult}.");
            System.Console.WriteLine($"Area of a circle with a radius of {radiusValue} is {areaResult}.");
            Console.ReadLine();
        }

        public static void CalculateCircumferenceAndArea(double radius, out double circumference, out double area)
        {
            circumference = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
        }

        #region 练习题二
        //让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且还要单独的返回给用户一个登陆信息。
        //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
        //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”
        #endregion
        static bool CheckLogin(string name, string passWord, ref string info)
            {
                //判断用户名是否正确
                if (name == "admin")
                {
                    //正确了做什么
                    //判断用户名 是否正确
                    if (passWord == "8888")
                    {
                        //正确了做什么
                        info = "登录成功";
                    }
                    else
                    {
                        //不正确做什么
                        info = "密码错误";
                        return false;
                    }
                }
                //不正确 做什么
                else
                {
                    info = "用户名错误";
                    return false;
                }
                return true;
            }

            
    }
}
