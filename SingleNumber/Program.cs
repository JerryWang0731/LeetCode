using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SingleNumber(new int[] { 2, 2, 1 });

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int SingleNumber(int[] nums)
        {
            var result = 0;

            if (nums.Length == 1)
            {
                return nums[0];
            }


            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i++)
            {
                var nowIndex = nums[i];

                if ((i - 1 >= 0) && (i + 1 < nums.Length))
                {
                    var preIndex = nums[i - 1];
                    var nextIndex = nums[i + 1];

                    if (nowIndex != preIndex && nowIndex != nextIndex)
                    {
                        return nowIndex;
                    }
                } 
                else if (i - 1 >= 0)
                {
                    var preIndex = nums[i - 1];
                    if (nowIndex != preIndex)
                    {
                        return nowIndex;
                    }
                } 
                else if (i + 1 < nums.Length)
                {
                    var nextIndex = nums[i + 1];
                    if (nowIndex != nextIndex)
                    {
                        return nowIndex;
                    }
                }
            }


            return result;
        }
    }
}
