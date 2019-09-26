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

    static int birthdayCakeCandles(int[] ar) {
            
            int count = 1;
            
            Array.Sort(ar);
            Array.Reverse(ar);

            if(ar[0] == ar[ar.Length-1])
            {
                count = ar.Length;
                return count;
            }


            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == ar[i+1])
                {
                    count++;
                }
                else
                    break;
            }


            Console.WriteLine(count);
            return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

