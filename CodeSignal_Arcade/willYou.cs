bool willYou(bool young, bool beautiful, bool loved) {

    
    if(loved == false && (young == true && beautiful == true))
    {
        return true;
    }
    else if(loved == true && (young == false || beautiful == false))
    {
        return true;
    }
        
    else 
        return false;
}
