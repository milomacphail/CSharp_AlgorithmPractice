int maxMultiple(int divisor, int bound) {
       
    int largestMultiple = 0;
    int multiplyBy = 1;
    
    do
    { 
        largestMultiple = (divisor * multiplyBy);
        multiplyBy++;
        
        if(bound - divisor < largestMultiple)
        {
            break;
        }

    } while (true);
    
    return largestMultiple;

}
