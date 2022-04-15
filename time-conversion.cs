//https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true

using System.IO;
using System;

class Result
{
    public static string timeConversion(string s)
    {
        return Convert.ToDateTime(s).ToString("HH:mm:ss");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
