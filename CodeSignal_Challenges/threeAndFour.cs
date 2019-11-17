int[] threeAndFour(int n) {
    
    List<int> divisibleNumbers = new List<int>();
    
    int i = 0;
    
    while(i < n)
    {
        if(i % 3 == 0 && i % 4 == 0)
        {
            divisibleNumbers.Add(i);
        }
        
        i++;
    }
    
    int[] divisibleArray = divisibleNumbers.ToArray();
    
    return divisibleArray;
}
