int[] metroCard(int lastNumberOfDays) {

    List <int> possibleDays = new List<int>();
    
    if (lastNumberOfDays == 30 || lastNumberOfDays == 28)
    {
        possibleDays.Add(31);
    }
    else if (lastNumberOfDays == 31)
    {
        possibleDays.Add(28);
        possibleDays.Add(30);
        possibleDays.Add(31);
    }
    
    
    int[] days = possibleDays.ToArray();
    
    return days;

}
