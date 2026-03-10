namespace ErWeiShuZu
{
    internal class ErWeiShuZu
    {
        static void Main(string[] args)
        {
            #region 题目1
            //Topic_1();
            //int num = 1;
            //int[,] array = new int[100, 100];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = num;
            //        num++;
            //        Console.WriteLine("{0},{1},{2}",i,j,array[i, j]);
            //    }
            //}
            #endregion

            #region 题目2
            //int[,] array = new int[4, 4];
            //Random r = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = (i <= 1 && j > 1) ? array[i,j] = 0 : array[i,j] = r.Next(1, 101);
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 题目3
            //int[,] array = new int[3,3];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 11);
            //        if (i == j || i + j == 2)
            //        {
            //            sum += array[i, j];
            //        }
            //        Console.Write(array[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 题目4
            //int[,] array = new int[5,5];
            //Random r = new Random();
            //int maxI = 0;
            //int maxJ = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i,j] = r.Next(1,501);
            //        if(array[i,j] > array[maxI,maxJ])
            //        {
            //            maxI = i;
            //            maxJ = j;
            //        }
            //        Console.Write(array[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("max:{0},maxI:{1},maxJ:{2}",array[maxI, maxJ],maxI + 1,maxJ + 1);
            #endregion

            #region 题目5
            //int[,] array = new int[10, 10] ;
            //Random r = new Random();
            //bool[] hang = new bool[10];
            //bool[] lie = new bool[10];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(0, 2);
            //        if (array[i,j] == 1)
            //        {
            //            hang[i] = true;
            //            lie[i] = true;
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}
            //Console.WriteLine("***********************************************");
            //for (int i = 0;i < array.GetLength(0); i++)
            //{
            //    for(int j = 0;j < array.GetLength(1); j++)
            //    {
            //        if (hang[i] || lie[j])
            //        {
            //            array[i, j] = 1;
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine() ;
            //}
            #endregion
            //Topic_2();
            //Topic_5();
            //string str1 = "123";
            //string str2 = str1;
            int[] a = new int[] { 10 };
            int[] b = a;
            b = new int[5];
            Console.WriteLine(a[0]);
        }


        static void Topic_1()
        {
            int[,] numbers = new int[10, 10];
            int firstNumber = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numbers[i, j] = firstNumber;
                    firstNumber++;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(numbers[i, j]);
                    if ((j + 1) % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Topic_2()
        {
            int[,] arr2 = new int[4, 4];
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //if (i <= j)
                    //{
                    //    arr2[i, j] = 0;
                    //}
                    //else 
                    //{
                    //    arr2[i, j] = r.Next(1, 101);
                    //} 
                    arr2[i, j] = i > j ? r.Next(1, 101) : 0;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2[i, j]);
                    if ((j + 1) % 4 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Topic_5()
        {
            int[,] arr5 = new int[5, 5];
            Random r = new Random();
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    arr5[i, j] = r.Next(0, 2);
                }
            }

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    Console.Write(arr5[i, j]);
                    if ((j + 1) % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    if (arr5[i, j] == 1)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            arr5[i, k] = 1;
                            arr5[k, j] = 1;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    Console.Write(arr5[i, j]);
                    if ((j + 1) % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
