int maxDigit(int n) {
    
    if (n == 0){
        return 0;
    }
    
    List<int> listOfInts = new List<int>();
    while(n > 0)
    {
        listOfInts.Add(n % 10);
        n = n / 10;
    }

    return listOfInts.Max();
}