bool checkPalindrome(string inputString) {

    string firstHalf = inputString.Substring(0, inputString.Length / 2);
    char[] charArray = inputString.ToCharArray();
    
    Array.Reverse(charArray);
    
    string temp = new string(charArray);
    
    string secondHalf = temp.Substring(0, temp.Length / 2);
    
    return firstHalf.Equals(second);
    
    
}
