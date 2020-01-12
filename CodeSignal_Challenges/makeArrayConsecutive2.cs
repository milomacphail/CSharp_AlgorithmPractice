int makeArrayConsecutive2(int[] statues) {

    Array.Sort(statues);
    
    int statuesNeeded = 0;
    
    for(int i = 0; i < statues.Length - 1; i++)
    {
        statuesNeeded += (statues[i + 1] - statues[i]) - 1;
    }
    
    return statuesNeeded;
    

}
