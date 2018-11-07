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
    
    // Complete the timeInWords function below.
    static string timeInWords(int h, int m) {

        List<String> numbers = new List<String>() {"o' clock", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "quarter", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight", "twenty nine", "half"};
        
        String hour = numbers[h];
        String total = "";
        
        if(m==0) {
            total = hour + " " + numbers[m];
        }
        else if(m==1) {
            total = numbers[m] + " minute past " + hour;
        }
        else if(m==15 || m==30) {
            total = numbers[m] + " past " + hour;
        }
        else if(m<=30) {
            total = numbers[m] + " minutes past " + hour;
        }
        else if(m>30) {
            hour = numbers[h+1];
            m = 60 - m;
            if(m==1)
                total = numbers[m] + " minute to " + hour;
            else if(m==15 || m==30)
                total = numbers[m] + " to " + hour;
            else
                total = numbers[m] + " minutes to " + hour;
        }
        
        return total;

    }

    static void Main(string[] args) {
        
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int h = Convert.ToInt32(Console.ReadLine());

        int m = Convert.ToInt32(Console.ReadLine());

        string result = timeInWords(h, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();

    }
}

