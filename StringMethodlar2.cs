using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var n = int.Parse(Console.ReadLine());
        var _inputs = new List<string>();
        var _result = new List<string>();
        
        for(int i = 0; i<n; i++)
        {
            var input = Console.ReadLine();
            _inputs.Add(input);
        }

        var result1 = "";
        var result2 = "";

        foreach(var item in _inputs){
            for(int i=0; i<item.Length;i++){
                if(i%2 == 0)
                {
                    result1 += item[i];
                }
                else
                {
                    result2 += item[i];
                }
            }
            _result.Add(result1 + " " + result2);
            result1 = "";
            result2 = ""; 
        }
        
        _result.ForEach(Console.WriteLine);
    }
}
