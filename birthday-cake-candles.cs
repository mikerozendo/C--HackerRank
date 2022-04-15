//https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int max = candles.Max();
        return (from value in candles where value == max select value).Count();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
        
        int result = Result.birthdayCakeCandles(candles);
        
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
