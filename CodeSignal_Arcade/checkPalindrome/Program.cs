﻿using System;

namespace checkPalindrome
{
    class MainClass
    {
        public static bool checkPalindrome(string inputString)
        {
                    string first = inputString.Substring(0, inputString.Length / 2);
                    char[] arr = inputString.ToCharArray();

                    Array.Reverse(arr);

                    string temp = new string(arr);
                    string second = temp.Substring(0, temp.Length / 2);

                    return first.Equals(second);
                    
        }
    }
}
