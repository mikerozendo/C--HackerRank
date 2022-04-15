//https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true

using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        if (arr.Count == 5)
        {
            long min = arr.Min();
            long max = arr.Max();
            Int64 minSum = 0;
            Int64 maxSum = 0;


            try
            {
                minSum = (from value in arr where value < max select value).Sum();
                maxSum = (from value in arr where value > min select value).Sum();

                if (maxSum == 0 && minSum == 0)
                {
                    arr.RemoveAt(0);
                    minSum = arr.Sum();
                    maxSum = arr.Sum();
                }
            }
            catch (OverflowException)
            {
                var minList = (from value in arr where value < max select value).ToList();
                var maxList = (from value in arr where value > min select value).ToList();

                minSum = 0;
                maxSum = 0;

                foreach (int value in minList)
                    minSum += value;

                foreach (int value in maxList)
                    maxSum += value;
            }

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Result.miniMaxSum(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
    }
}
