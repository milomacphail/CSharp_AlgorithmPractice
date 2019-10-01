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

    // Complete the countingValleys function below.
    /*static int countingValleys(int n, string s) {
    }*/
    static void Main(string[] args) {

           int alt = 0;
           int valleyCount = 0;
           int steps = int.Parse(Console.ReadLine());
           char[] garySteps = Console.ReadLine().ToArray();
           bool isValley = false;

           for (int i = 0; i < steps; i++)
           {
               if (garySteps[i] == 'U')
               {
                   alt ++;
               }
               else
               {
                   alt --;
               }
               if (!isValley && alt < 0)
               {
                   isValley = true;
               }
               if (isValley == true && alt == 0)
               {
                   valleyCount ++;
                   isValley = false;
               }
           }
            Console.WriteLine(valleyCount);
    }
}
