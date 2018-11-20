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
using System.Numerics;

class Solution {

    // Complete the extraLongFactorials function below.
    static BigInteger extraLongFactorials(int n) {
        if(n==1) {
            return 1;
        }
        else {
            return n * extraLongFactorials(n-1);
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger result = extraLongFactorials(n);
        Console.WriteLine(result);      
    }
}

