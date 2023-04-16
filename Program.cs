﻿using System.CodeDom.Compiler;
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



class Result
{
    public static void fizzBuzz(int n)
    {
        string result = "";
        for (int i = 1; i <= n; i++)
        {

            result = i.ToString();

            if (i % 5 == 0)
            {
                result = "Buzz";
            }
            if (i % 3 == 0)
            {
                result = "Fizz";
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
            }
            Console.WriteLine(result);
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
