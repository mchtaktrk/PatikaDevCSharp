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



class Solution
{

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        var result = BubbleSort(n, a);
   
        Console.WriteLine("Array is sorted in {0} swaps." , result[0]);
        Console.WriteLine("First Element: {0}", result[1]);
        Console.WriteLine("Last Element: {0}", result[2]);
        
    }
    public static List<int> BubbleSort(int n, List<int> arr){
        int first = arr[0];
        int last = arr[0];
        int numberOfSwaps = 0;
        
        for (int i = 0; i < n; i++) {
        // Track number of elements swapped during a single array traversal
            
            if(arr[i] > last){
                last = arr[i];
                
            }
            if(arr[i] < first)
            {
                first = arr[i];
            }
           
            for (int j = 0; j < n - 1; j++) {
            // Swap adjacent elements if they are in decreasing order
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j]= arr[j+1];
                    arr[j+1] = temp;
                    numberOfSwaps++;
                }
            }   
            // If no elements were swapped during a traversal, array is sorted
            /*if (numberOfSwaps == 0) {
                break;
            }*/
        }
        return new List<int>{numberOfSwaps,first,last};
    }

    
    

}
