int evenNumbersBeforeFixed(int[] sequence, int fixedElement) {
    
    int evenNumbers = 0;
    
    if (sequence.Contains(fixedElement) == false)
    {
        return -1;
    }
    
    for(int i = 0; i < Array.IndexOf(sequence, fixedElement); i++)
    {
        if(sequence[i] % 2 == 0)
        {
            evenNumbers++;
        }
    }
    
    return evenNumbers;

}
