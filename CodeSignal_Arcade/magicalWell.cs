int magicalWell(int a, int b, int n) {
    
    int throws = 0;
    int cash = 0;
    
    while(throws < n)
    {
        throws++;
        cash += (a * b);
        a++;
        b++;
    }
        
    return cash;
}