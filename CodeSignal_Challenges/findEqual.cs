bool findEqual(int[] sequence) {
    
    bool equalValues = false;
    Array.Sort(sequence);
    
    
    for(int i = 0; i < sequence.Length - 1; i++)
    {
        if(sequence[i] == sequence[i+1]){
            equalValues = true;
        }
    }

    return equalValues;
}

