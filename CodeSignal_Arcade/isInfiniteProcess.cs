bool isInfiniteProcess(int a, int b) {
    
    bool infinite = true;
    
    if(a<=b && (a + b) % 2 == 0)
    {
        infinite = false;
    }
    
    return infinite;
}