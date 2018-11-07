using System;
using System.Collections.Generic;
using System.IO;
class Solution {

// Complete the solveMeFirst function below.
    static int solveMeFirst(int a, int b) { 
      // Hint: Type return a+b; below  
        return a+b;
      
    }

    static void Main(String[] args) {
        // Read first integer value
        int val1 = Convert.ToInt32(Console.ReadLine());
        // Read second integer value
        int val2 = Convert.ToInt32(Console.ReadLine());
        // Calculate the sum of two values
        int sum = solveMeFirst(val1,val2);
        // Display the sum
        Console.WriteLine(sum);
    }
}      