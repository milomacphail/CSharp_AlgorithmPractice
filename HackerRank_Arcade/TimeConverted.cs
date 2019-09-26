using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s) {

        DateTime converted = DateTime.Parse(s);

        string reConverted = converted.ToString("HH:mm:ss");

        return reConverted;

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
