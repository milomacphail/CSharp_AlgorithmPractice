int differentSymbolsNaive(string s) {
    
    int uniques = 0;
    
    List <char> charList = new List <char>();
    
    for(int i = 0; i < s.Length; i++)
    {
      if(charList.Contains(s[i]) == false)
      {
          charList.Add(s[i]);
          uniques++;
      }
    }

    return uniques;
    
}
