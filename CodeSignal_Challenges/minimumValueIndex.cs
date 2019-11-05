int arrayMinimumIndex(int[] inputArray) {
    
    int minimumValue = inputArray.Min();
    int index = 0;
    
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] == minimumValue)
        {
            index = i;
        }            
    }

    return index;
}
