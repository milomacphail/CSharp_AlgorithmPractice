int candies(int n, int m) {
    
    int rem = m % n;
    
    int sum = Math.Abs(rem - m);
    
    return sum;
    

}
