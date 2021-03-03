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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var arraySize = arr.Count;
        
        int diagnoalSum = 0;
        int reverseDiagnoalSum = 0;
        
        // principal diagonal
        for (int i=0; i <= arraySize -1; i++) {
            for (int j=0; j <= arraySize - 1; j++) {
                if (i == j) {
                    diagnoalSum += arr[i][j];
                }
            }
        }
        
        // secondary diagonal
        for (int i=0; i <= arraySize - 1; i++) {
            for (int j=0; j <= arraySize - 1; j++) {
                if ((i+j) == (arraySize - 1)) {
                    reverseDiagnoalSum += arr[i][j];
                }
            }
        }
        
        var result = diagnoalSum - reverseDiagnoalSum; 
        
        return Math.Abs(result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
