string longestWord(string text) {
    
    string textEdit = Regex.Replace(text,"[^A-Za-z ]"," ");

    string[] splitString = textEdit.Split(' ');

    int max = splitString[0].Length;
            
    string maxx= splitString[0];
        
    for (int i = 0; i < splitString.Length; i++)
        {
            int length = splitString[i].Length;   
            
            if (length > max)
            {
                maxx = splitString[i];
                max = splitString[i].Length;
            }
    }

    
    return maxx;
    
}