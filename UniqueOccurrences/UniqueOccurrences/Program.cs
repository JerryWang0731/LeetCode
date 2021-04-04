using System;
using System.Collections.Generic;

namespace UniqueOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //var inputArr = new int[]{1, 2, 2, 1, 1, 3};

            var inputArr = new int[] { 1, 2 };


            //var inputArr = new int[] { -4, 3, 3 };

            var result = UniqueOccurrences(inputArr);

            Console.WriteLine(result);
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            var result = true;

            Array.Sort(arr);

            var lengHistory = new Dictionary<int, int>();

            var count = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                count++;

                var item = arr[i];

                if (i == arr.Length - 1 || item != arr[i+1])
                {
                    if (lengHistory.ContainsValue(count))
                    {
                        return false;
                    }
                    
                    lengHistory[item] = count;
                    count = 0;
                }
            }

            return result;
        }
    }
}
