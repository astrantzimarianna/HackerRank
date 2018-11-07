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

    // Complete the isValid function below.
    static string isValid(string s) {

        int index = 0;
        int counter = 0;
        List<string> characters = new List<string>();
        List<int> repeated = new List<int>();
        foreach (char c in s) {
            var match = characters.FirstOrDefault(ch => ch.Contains(c));
            if(match==null) {
                characters.Add(c.ToString());
                repeated.Add(1);
            }
            else {
                index = characters.FindIndex(x => x.Equals(c.ToString()));
                repeated[index] += 1;
            }
            counter++;
        }
        
        int no = 0;
        int firstNumber = repeated[0];
        string output = "YES";
        foreach (int number in repeated) {
            if(number!=firstNumber) {
                no++;
                if(no>1) {
                output = "NO";
                break;
                }
            }
        }
        
        return output;

    }

    static void Main(string[] args) {

        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        
    }
}

