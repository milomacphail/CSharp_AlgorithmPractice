bool chessBoardCellColor(string cell1, string cell2) {
    
    bool match = true;
    
    int firstChar = Math.Abs((cell1[0] - cell2[0]) % 2);                         
    int secondChar = Math.Abs((cell1[1] -cell2[1]) % 2);
    
    if(firstChar != secondChar)
    {
        match = false;
    }
    
    return match;

}