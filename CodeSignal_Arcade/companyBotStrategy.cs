double companyBotStrategy(int[][] trainingData) {
    
    List <int[]> correctTimes = new List<int[]>();
    
    double botSum = 0;
    
    for (int topLevel = 0; topLevel < trainingData.Length; topLevel++)
    {
            if (trainingData[topLevel][1] == 1)
            {
                correctTimes.Add(trainingData[topLevel]);
                Console.WriteLine(trainingData[topLevel][1]);
            }
    }
    
    if (correctTimes.Count > 0)
    {
       for(int firstIndex = 0; firstIndex < correctTimes.Count; firstIndex++)
           botSum += (correctTimes[firstIndex][0]);
           Console.WriteLine(botSum);
           botSum /= correctTimes.Count;
            
    } 
    
    return (double)botSum;
}
