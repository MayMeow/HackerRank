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

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        
        int posCount = 0;
        int negCount = 0;
        int zeros = 0;
        
        int arrayLength = arr.Count();
        
        for (int i = 0; i < arr.Count(); i ++)
        {
            if (arr[i] > 0) {
                posCount++;
            }
            
            if (arr[i] < 0) {
                negCount++;
            }
            
            if (arr[i] == 0) {
                zeros++;
            }
        }
        
        Console.WriteLine(Math.Round((double)posCount / arrayLength, 6));
        Console.WriteLine(Math.Round((double)negCount / arrayLength, 6));
        Console.WriteLine(Math.Round((double)zeros / arrayLength, 6));

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
