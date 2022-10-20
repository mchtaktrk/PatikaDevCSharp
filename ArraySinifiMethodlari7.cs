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


public class Item 
{
    public int ItemValue { get; set; }
    public int ItemFrequency { get; set; }
}
class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {

        List<Item> frequencies = new List<Item>();
        var maxFrequency = new Item(){ItemValue = 0, ItemFrequency = 0};
        foreach(var item in arr){
            var obj = frequencies.Find(p=> p.ItemValue == item);
            
            if(obj != null){
                
                obj.ItemFrequency++;
                
                if(maxFrequency.ItemFrequency < obj.ItemFrequency){
                    maxFrequency = obj;
                }else if (maxFrequency.ItemFrequency == obj.ItemFrequency){
                    if(maxFrequency.ItemValue > obj.ItemValue){
                        maxFrequency = obj;
                    }
                }   
            }else{
                frequencies.Add(new Item() {ItemValue = item, ItemFrequency = 1 });
            }
            
        }
        return maxFrequency.ItemValue;
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
