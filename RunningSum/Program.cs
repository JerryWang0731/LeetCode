using System;
using System.Collections.Generic;

namespace RunningSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[] { 3, 1, 2, 10, 1 };

            var result = RunningSum(inputArray);


            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int[] RunningSum(int[] nums)
        {
            var sumArray =  new List<int>();

            var sum = 0;


            foreach (var item in nums)
            {
                sum += item;

                sumArray.Add(sum);
            }


            return sumArray.ToArray();
        }


    }
}
