int largestNumber(int n) {
    
    List <int> number = new List <int>();
    
    for(int i = 0; i < n; i++)
    {
        number.Add(9);
    }
    
    int result = int.Parse(string.Join(",", number).Replace(",", ""));
                           
    return result;
}
