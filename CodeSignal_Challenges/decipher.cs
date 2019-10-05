string decipher(string cipher) {
    
    string stringToReturn = cipher;
    string result = "";
    
    while (stringToReturn.Length > 0)
    {
        int tempLetter = Convert.ToInt32(stringToReturn.Substring(0,2));
        
        if (tempLetter < 32)
        {
            tempLetter = Convert.ToInt32(stringToReturn.Substring(0,3));
        }
        
        result += (Convert.ToChar(tempLetter)).ToString();
        
        stringToReturn = stringToReturn.Substring(tempLetter.ToString().Length, stringToReturn.Length - tempLetter.ToString().Length);
    
    }
    
        return result;

}
