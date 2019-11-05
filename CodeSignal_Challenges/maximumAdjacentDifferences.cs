int arrayMaximalAdjacentDifference(int[] inputArray) {
    
    int adjacentDifferences = 0;
    
    for(int i = 1; i < inputArray.Length; i++)
    {
        int tempAdjacentDifferences = Math.Abs(inputArray[i] - (inputArray[i -1]));
        
        if(tempAdjacentDifferences > adjacentDifferences)
        {
            adjacentDifferences = tempAdjacentDifferences;
        }
    }
    
    Console.WriteLine(adjacentDifferences);
    return adjacentDifferences;

}
