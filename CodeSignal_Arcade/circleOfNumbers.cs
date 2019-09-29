int circleOfNumbers(int n, int firstNumber) {
    
    
    int directlyAcross = 0;
    
    if(firstNumber < (n/2))
    {
        directlyAcross = (firstNumber + (n/2));
    }
    else
    {
        directlyAcross = (firstNumber - (n/2));
    }
    
    return directlyAcross;
    

}
