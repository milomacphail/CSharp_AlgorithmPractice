int[] alternatingSums(int[] a) {
    
    List<int> firstTeamWeight = new List<int>();
    List<int> secondTeamWeight = new List<int>();
    List<int> totalWeights = new List<int>();
    
    for(int i = 0; i < a.Length; i++)
    {
        if(i % 2 == 0)
        {
            firstTeamWeight.Add(a[i]);
        }
        else
        {
            secondTeamWeight.Add(a[i]);   
        }
    }
    
    int firstTeamTotal = firstTeamWeight.Sum();
    int secondTeamTotal = secondTeamWeight.Sum();
    
    totalWeights.Add(firstTeamTotal);
    totalWeights.Add(secondTeamTotal);
    
    int[] finalWeights = totalWeights.ToArray();
    
    return finalWeights;

}
