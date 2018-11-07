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

    // Complete the staircase function below.
    static void staircase(int n) {
        for(int i=1; i<=n; i++) {
            string line = "";
            int spaces = n-i;
           for(int s=1; s<=spaces; s++) {
                line += " ";
            }
            for(int j=1; j<=i; j++) {
                line += "#";
            }
            Console.WriteLine(line);
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}

