char firstDigit(string inputString) {

    char digit = '1';
    
    for(int i = 0; i < inputString.Length; i++)
    {
        if (inputString[i] >= '0' && inputString[i] <= '9')
        {
            digit = inputString[i];
            break;
        }
    }
    
    return digit;
    
}
