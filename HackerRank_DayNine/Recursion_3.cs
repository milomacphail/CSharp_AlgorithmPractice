using System.Collections;
using System;

class Solution {

    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine(factorial(n));
    }


    static int factorial(int n) {
        if (n == 1)
        {
            return 1;
        }
        
        return (n * n-1));
    }
}
