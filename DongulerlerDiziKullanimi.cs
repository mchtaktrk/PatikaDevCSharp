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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count;
        if(n >= 0 && n <= 100){
        decimal negative = 0;
        decimal positive = 0;
        decimal zeros = 0;
        foreach(var item in arr){
           if(item == 0){
               zeros++;               
           }else if(item > 0){
               positive++;               
           }else{
               negative++;
           }
        }
        
        Console.WriteLine(Decimal.Round((positive/n) , 5));
        Console.WriteLine(Decimal.Round((negative/n) , 5));
        Console.WriteLine(Decimal.Round((zeros/n) , 5));
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        Result.plusMinus(arr);
    }
}
