int houseNumbersSum(int[] inputArray) {
    
    int stop = Array.IndexOf(inputArray, 0);
    int sum = 0;
    
    for(int i = 0; i < stop; i++)
    {
        sum+=inputArray[i];       
    }
    
    return sum;

}
