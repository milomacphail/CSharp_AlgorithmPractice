using System;

int[] longestUncorruptedSegment(int[] sourceArray, int[] destinationArray)
{

    int[] uncorruptedSegment = new int[2];
    int uncorruptedCounter = 0;
    int uncorruptedIndex = 0;
    int longestSegment = 0;

    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i] != destinationArray[i])
        {
            if (uncorruptedCounter > longestSegment)
            {
                longestSegment = uncorruptedCounter;
                uncorruptedSegment[0] = longestSegment;
                uncorruptedSegment[1] = uncorruptedIndex;
            }
            uncorruptedCounter = 0;
            continue;
        }
        else
        {
            if (uncorruptedCounter < 1)
            {
                uncorruptedIndex = i;
            }
            uncorruptedCounter++;
        }
        if (uncorruptedCounter > longestSegment)
        {
            longestSegment = uncorruptedCounter;
            uncorruptedSegment[0] = longestSegment;
            uncorruptedSegment[1] = uncorruptedIndex;
        }
    }

    return uncorruptedSegment;
}