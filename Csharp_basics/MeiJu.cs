namespace MeiJu

{
    enum E_QQType
    {
        Online,
        Leave,
        Busy,
        Invisble,
    }

    enum E_CafeType
    {
        M,
        B,
        S,
    }

    enum E_Sex
    {
        Man,
        Woman,
    }
    enum E_Occupation
    {
        Warrior,
        Hunter,
        Master,
    }
    internal class MeiJu
    {
        static void Main(string[] args)
        {
            #region 习题1
            Console.WriteLine("请输入在线状态，在线0，离开1，忙碌2，隐身3");
            int type = int.Parse(Console.ReadLine());
            E_QQType qqType = (E_QQType)type;
            Console.WriteLine(type);
            Console.WriteLine(qqType);
            #endregion

            #region 习题2
            Console.WriteLine("请选择需要的杯型，中杯0，大杯1，超大杯2");
            int cafeType = int.Parse(Console.ReadLine());
            E_CafeType cType = (E_CafeType)cafeType;
            switch (cType)
            {
                case E_CafeType.M:
                    Console.WriteLine("你购买了中杯咖啡，花费了35元");
                    break;
                case E_CafeType.B:
                    Console.WriteLine("你购买了大杯咖啡，花费了40元");
                    break;
                case E_CafeType.S:
                    Console.WriteLine("你购买了超大杯咖啡，花费了43元");
                    break;
            }
            #endregion

            #region 习题3
            //Console.WriteLine("请选择性别,男0，女1");
            //E_Sex sex = (E_Sex)int.Parse(Console.ReadLine());
            //string sexStr = "";
            //int atk = 0;
            //int def = 0;
            //switch (sex)
            //{
            //    case E_Sex.Man:
            //        sexStr = "男";
            //        atk = 50;
            //        def = 100;
            //        break;
            //    case E_Sex.Woman:
            //        sexStr = "nv";
            //        atk = 150;
            //        def = 20;
            //        break;
            //}
            //Console.WriteLine("请选择职业，战士0，猎人1，法师2");
            //E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
            //string skill = "";
            //string occupation = "";
            //switch (o)
            //{
            //    case E_Occupation.Warrior:
            //        atk += 20;
            //        def += 100;
            //        skill = "冲锋";
            //        occupation = "战士";
            //        break;
            //    case E_Occupation.Hunter:
            //        atk += 120;
            //        def += 30;
            //        skill = "假死";
            //        occupation = "猎人";
            //        break;  
            //    case E_Occupation.Master:
            //        atk += 200;
            //        def += 10;
            //        skill = "奥术冲击";
            //        occupation = "法师";
            //        break;
            //}
            //Console.WriteLine("atk:{0},def:{1},skill:{2}",atk,def,skill);
            #endregion
        }
    }
}
