int fixedPointsPermutation(int[] permutation) {
    
    int counter = 0;
    
    for(int i = 0; i < permutation.Length; i++){
        if(i == permutation[i] -1)
        {
            counter++;
        }
    }
    
    return counter;

}
