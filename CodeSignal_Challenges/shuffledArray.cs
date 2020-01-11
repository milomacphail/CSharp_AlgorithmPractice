int[] shuffledArray(int[] shuffled) {
    
    Array.Sort(shuffled);
    
    List<int> arrayToList = shuffled.ToList();
    
    for(int i = 0; i < arrayToList.Count; i++)
    {
        if((arrayToList.Sum() - arrayToList[i]) == arrayToList[i])
        {
            arrayToList.Remove(arrayToList[i]);
            break;
        }
    }
    
    return arrayToList.ToArray();
}

