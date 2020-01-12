string[] allLongestStrings(string[] inputArray) {
    
    List<string> longestString =  new List<string>();
int longestStringLength = inputArray[0].Length;
    
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length > longestStringLength)
        {
            longestStringLength = inputArray[i].Length;
        }
    }
    
    for(int j = 0; j < inputArray.Length; j++)
    {
        if(inputArray[j].Length == longestStringLength)
        {
            longestString.Add(inputArray[j]);
        }
    }
    
    return longestString.ToArray();
    
}