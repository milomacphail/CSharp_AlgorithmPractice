bool isSum(int value) {
    
    int n = 1;
    int sum = 0;
    bool isTriSum = false;
    
    while (n <= value)
    {
        sum += n;
        n++;
        
        if (sum == value)
        {
            isTriSum = true;
        }
    }

    return isTriSum;
}