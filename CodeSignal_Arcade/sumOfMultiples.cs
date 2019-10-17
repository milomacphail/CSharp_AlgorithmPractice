int sumOfMultiples(int n, int k) {

    int i = 0;
    int j = 1;
    
    while((j * k) <= n)
    {
        i += (j*k);
        j++;
    }
    
    return i;
}
