int minimalMultiple(int divisor, int lowerBound) {
    
    int n = lowerBound -1;
    
    do{
        n++; 
    } while (n % divisor != 0);
    
    return n;
}
