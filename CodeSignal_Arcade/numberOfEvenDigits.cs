int numberOfEvenDigits(int n) {
    
    int totalEvenDigits = 0;
    
    List<int> listOfInts = new List<int>();
    
    while(n > 0)
    {
        listOfInts.Add(n % 10);
        n = n / 10;
    }
    
    for (int i = 0; i < listOfInts.Count; i++)
    {
        if(listOfInts[i] % 2 == 0)
        {
            totalEvenDigits++;
        }
    }
    return totalEvenDigits;
}
