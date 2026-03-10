namespace ShuZu
{
    internal class ShuZu
    {
        static void Main(string[] args)
        {
            #region 题目1
            //Topic_1();
            //int[] arrayA = new int[100];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    arrayA[i] = i;
            //    Console.WriteLine("{0}, {1}", arrayA[i], i);
            //}
            #endregion

            #region 题目2
            //int[] arrayB = new int[100];
            //for(int i = 0;i < arrayB.Length;i++)
            //{
            //    arrayB[i] = arrayA[i] * 2;
            //    Console.WriteLine(arrayB[i]);
            //}
            #endregion

            #region 题目3
            //Random r = new Random();
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}

            #endregion

            #region 题目4
            //Random r = new Random();
            //int[] array = new int[10];
            //int min = 100;
            //int max = 0;
            //int sum = 0;
            //int avg = 0;
            //for (int i = 0; i < array.Length; i++)
            //{

            //    array[i] = r.Next(0, 101);
            //    if (array[i] > max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //    sum += array[i];
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("max={0},min={1},sum={2},avg={3}",max,min,sum,sum / array.Length);
            #endregion

            #region 题目5
            //Topic_5();
            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int mid;
            //int end = array.Length-1;
            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    mid = array[i];
            //    array[i] = array[end];
            //    array[end] = mid;
            //    end--;
            //}
            //for (int i = 0; i <= array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 题目6
            //int[] array = {-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5};
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ",");
            //    if (array[i] < 0)
            //    {
            //        array[i]++;
            //    }
            //    else if (array[i] > 0)
            //    {
            //        array[i]--;
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ",");
            //}
            #endregion

            #region 题目7
            //int[] array = new int[10];
            //int max = 0;
            //int min = 0;
            //int sum = 0;
            //int avg = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine("请输入数学成绩:");
            //    array[i] = int.Parse(Console.ReadLine());
            //    if (i == 0)
            //    {
            //        max = array[i];
            //        min = array[i];
            //    }
            //    else
            //    {
            //        if (array[i] > max)
            //        {
            //            max = array[i];
            //        }
            //        if (array[i] < min)
            //        {
            //            min = array[i];
            //        }
            //        sum += array[i];
            //    }
            //}
            //for (int i = 0; i < array.Length;i++)
            //{
            //    Console.Write(array[i] + ",");
            //}
            //avg = sum / array.Length;
            //Console.WriteLine();
            //Console.WriteLine("{0},{1},{2}", max, min, avg);
            #endregion

            #region 题目8
            //Topic_8();
            //string[] array = new string[25];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i % 2 == 0 ? "$" : "#";
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]);
            //    if((i + 1) % 5 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            #endregion
        }

        static void Topic_1()
        {
            int[] arr1 = new int[100];
            for(int i  = 0; i < arr1.Length; i++)
            {
                arr1[i] = i;
                Console.WriteLine("arr {0} = {1}", i, arr1[i]);
            }
        }

        static void Topic_5()
        {
            int[] arr5 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for(int i = 0;i < arr5.Length / 2;i++)
            {
                int mid;
                mid = arr5[i];
                arr5[i] = arr5[arr5.Length - i - 1];
                arr5[arr5.Length - i - 1] = mid;
                
            }
            for(int i = 0;i < arr5.Length;i++)
            {
                Console.WriteLine(arr5[i]);
            }

        }

        static void Topic_8()
        {
            char[] chars = new char[25];
            for(int i = 0;i < chars.Length;i++)
            {
                if(i %  2 == 0)
                {
                    chars[i] = 'a';
                }
                else
                {
                    chars[i] = 'b';
                }
            }

            for (int i = 0; i < chars.Length;i++)
            {
                Console.Write(chars[i]);
                if((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
