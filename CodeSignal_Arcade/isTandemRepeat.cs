bool isTandemRepeat(string inputString) {
    
    string firstHalf = inputString.Substring(0, inputString.Length/2);
    string secondHalf = inputString.Substring(inputString.Length/2, inputString.Length/2);
    
    if(inputString.Length % 2 != 0){
        return false;   
    }
    if(firstHalf == secondHalf)
    {
        return true;
    }
    else return false;
}
