int halvingSum(int n) {
    
    int sum = 0;
    int divisor = 1;
    
    while((n/divisor) >= 1){
        sum += (n/divisor);
        divisor *= 2;
        Console.WriteLine(sum);
    }
    
    return sum;

}
