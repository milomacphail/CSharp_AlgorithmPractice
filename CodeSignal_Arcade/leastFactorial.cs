int leastFactorial(int n) {
    
    int factorial = 1;
    
    for(int i = 1; factorial < n; i++)
    {
        factorial *= i;
    }
    
    return factorial;
}
