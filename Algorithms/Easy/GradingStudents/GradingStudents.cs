using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    // Complete the gradingStudents function below.
    static int[] gradingStudents(int[] grades) {
        List<int> list = new List<int>();

        foreach (int grade in grades) {
            int temp_grade = grade;
            if(grade>=38 && grade!=100) {
               int nearestMultiple10 = (int)(temp_grade / 10);
                nearestMultiple10 = nearestMultiple10 + 1;
                nearestMultiple10 = nearestMultiple10 * 10;
                if(nearestMultiple10-grade<3) {
                    temp_grade = nearestMultiple10;
                }
                else if((nearestMultiple10-grade>4) && (nearestMultiple10-grade<8)) {
                    temp_grade = nearestMultiple10-5;
                }
            }
            list.Add(temp_grade);
        }
        
        return list.ToArray();
    }
    
        static int RoundOff (int number)
    {
        return (int)(Math.Ceiling((decimal)number / 10));
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}

