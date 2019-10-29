int[] tasksTypes(int[] deadlines, int day) {
    
    
    int[] returnArray = new int[3];
    
    for(int i = 0; i < deadlines.Length; i++)
    {
        if (deadlines[i] <= day)
        {
            returnArray[0]++;
        }
        else if(deadlines[i] > day && deadlines[i] <= (day + 7))
        {
            returnArray[1]++;
        }
        else{
            returnArray[2]++;
        }
    }

   return returnArray;
    
    
    
}