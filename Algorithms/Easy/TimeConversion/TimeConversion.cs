using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

     // Complete the timeConversion function below.
    static string timeConversion(string s) { 
        int inthours = Int32.Parse(s.Substring(0, 2));
        string hours = "";
        string minutes = s.Substring(3, 2);
        string seconds = s.Substring(6, 2);
        string ampm = s.Substring(8, 2);
        
        switch(ampm) {
            case "AM":
                if(inthours==12) {
                    hours = "00"; }
                else if(inthours<10) {
                    hours = "0"+inthours.ToString(); }
                else { hours = inthours.ToString(); }
                break;
            case "PM":
                if(inthours!=12){
                hours = (inthours+12).ToString();}
                else {hours = (inthours).ToString();}
                break;
        }
        
        return hours + ":" + minutes + ":" + seconds;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}

