namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] n = new int[20];
            n = Sort(arr, true);
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            
        }

        static int[] Sort(int[] nums, bool upOrDown)
        {
            
            bool isOk = false;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                isOk = false;
                for(int j = 0; j < nums.Length - i - 1; j++)
                {

                    bool sort = upOrDown ? nums[j] > nums[j + 1] : nums[j] < nums[j + 1];
                    if (sort)
                    {
                        int t = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = t;
                        isOk = true;
                    }
                }
                if(!isOk)
                {
                    break;
                }
            }
            return nums;
        }
    }
}
