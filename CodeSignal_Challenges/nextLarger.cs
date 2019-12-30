int[] nextLarger(int[] a) {
    
    int[] returnArray = new int[a.Length];
    
    int next, i, j;
    returnArray[a.Length -1] = -1;
    
    
    for(i = 0; i < a.Length; i++)
    {
        for(j = i + 1; j < a.Length; j++)
        {
            if(a[i] < a[j])
            {
                next = a[j];
                returnArray[i] = next;
                break;
            }
            else{
                returnArray[i] = -1;
            }
        }
    }
    
    return returnArray;
}