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

    // Complete the encryption function below.
    static string encryption(string s) {
        s = s.Replace(" ", "");
        int L = s.Length;
        int rows = 0;
        int columns = 0;
        int round = 0;
        int ceil = 0;
        double rootSquare = Math.Sqrt(L);

        if ((rootSquare % 1) == 0) { // is integer
        rows = (int)rootSquare;
        columns = (int)rootSquare;
        }
        else { // is not integer
        round = (int)Math.Round(rootSquare);
        ceil = (int)Math.Ceiling(rootSquare);
        if (round*ceil<L) {
            rows = ceil;
            columns = ceil;
        }
        else {
            rows = round;
            columns = ceil;
        }
        }

        char[,] array = new char[rows,columns];
        int counter = 0;
        for (int i=0; i<rows; i++) {
            for (int j=0; j<columns; j++) {
                if(counter<L) {
                array[i,j] = s[counter];
                }
                else {
                   array[i,j] = ' '; 
                }
                counter++;
            }
        }

        string result = "";
        
        for (int z=0; z<columns; z++) {
            if(z>0) {
                result += " ";
            }
            for (int u=0; u<rows; u++) {
                if(!array[u,z].Equals(' '))
                result += array[u,z];
            }
        }
        Console.WriteLine(rows + " " + columns);
        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

