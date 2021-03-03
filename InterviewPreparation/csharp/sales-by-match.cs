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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        var pairs = new Dictionary<int, int>();

        for (int i = 0; i < ar.Length; i++) {
            if (pairs.ContainsKey(ar[i])) {
                pairs[ar[i]]++; //add item to pair
            } else {
                pairs[ar[i]] = 1; //create pair
            }
        }
        
        int totalPairs = 0;
        
        foreach(var pair in pairs) {
            // pair is 2 or more and must be dividable by 2
            if (pair.Value >= 2) {
                totalPairs += (int)pair.Value / 2;
            }
        }
        
        return totalPairs;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
