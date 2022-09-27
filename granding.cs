//https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

int.TryParse(Console.ReadLine().Trim(), out int lines);

if (lines >= 1 && lines <= 60)
{
    List<int> grades = new List<int>();

    for (int i = 0; i < lines; i++)
    {
        int.TryParse(Console.ReadLine().Trim(), out int gradesItem);

        if (gradesItem >= 0 && gradesItem <= 100)
        {
            grades.Add(gradesItem);
        }
    }

    List<int> result = Result.gradingStudents(grades);

    Console.WriteLine(String.Join("\n", result));
}


public static class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> results = new();
        foreach (int grade in grades)
        {
            if (grade >= 38)
            {
                if (getMultiples().Any(x => x > grade))
                {
                    int multiple = getMultiples().Where(x => x > grade).ToArray()[0];
                    int resultOperation = multiple - grade;

                    int gradeResult = resultOperation < 3 ? multiple : grade;

                    results.Add(gradeResult);
                }
                else
                {
                    results.Add(grade);
                }

                continue;
            }

            results.Add(grade);
        }

        return results;
    }
    private static List<int> getMultiples()
    {
        return new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };
    }
}

