bool evenDigitsOnly(int n) {
    
    List<int> listOfInts = new List<int>();
    bool onlyEvens = true;
    
    while(n > 0)
    {
        listOfInts.Add(n % 10);
        n = n / 10;
    }
    
    for(int i = 0; i < listOfInts.Count; i++)
    {
        if(listOfInts[i] % 2 == 1)
        {
            onlyEvens = false;
            break;
        }
    }
    
    return onlyEvens;

}