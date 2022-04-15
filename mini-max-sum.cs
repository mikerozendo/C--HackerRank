//https://www.hackerrank.com/challenges/mini-max-sum/problem?isFullScreen=true

using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        if (arr.Count > 0)
        {
            int min = arr.Min();
            int max = arr.Max();

            int minSum = (from value in arr where value < max select value).Sum();
            int maxSum = (from value in arr where value > min select value).Sum();

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
