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
        decimal length = arr.Length;
        decimal positives = 0;
        decimal negatives = 0;
        decimal zeros = 0;
        
        foreach (int element in arr) {
            if(element>0) {
                positives += 1;
            }
            else if(element<0) {
                    negatives += 1;
            }
            else { zeros += 1; }
        }
        
        decimal decpos = positives/length;
        decimal decneg = negatives/length;
        decimal deczer = zeros/length;
        
        Console.WriteLine(decpos.ToString());
        Console.WriteLine(decneg);
        Console.WriteLine(deczer);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}

