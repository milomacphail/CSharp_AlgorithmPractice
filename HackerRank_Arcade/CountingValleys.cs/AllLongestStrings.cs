using System;

string[] allLongestStrings(string[] inputArray)
{

    string longestWord = "";
    int longestLength = 0;
    List<string> longestStrings = new List<string>();

    foreach (string word in inputArray)
    {

        if (longestWord.Length < word.Length)
        {
            longestStrings.Clear();
        }

        if (word.Length >= longestLength)
        {
            longestLength = word.Length;
            longestWord = word;
            longestStrings.Add(word);
        }

    }

    string[] finalArray = longestStrings.ToArray();

    return finalArray;
}
