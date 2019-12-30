bool checkIncreasingSequence(int[] seq) {
    
    for(int i = 0; i < seq.Length - 1; i++)
    {
        if(seq[i] >= seq[i + 1])
        {
            return false;
        }
    }
    
    return true;

}
