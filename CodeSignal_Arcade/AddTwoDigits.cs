int addTwoDigits(int n)
{
    List<int> listOfInts = new List<int>();
    while(n > 0)
    {
        listOfInts.Add(n % 10);
        n = n / 10;
    }
    listOfInts.Reverse();
    
    listOfInts.ToArray();
    
    return listOfInts.Sum();
}