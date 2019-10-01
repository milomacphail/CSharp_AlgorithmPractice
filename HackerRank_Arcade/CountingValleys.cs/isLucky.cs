bool isLuckyNumber(int n) {
     
     List <int> nArray = new List <int>();
     
    while (n != 0)
    {
        nArray.Add(n % 10);
        n /= 10;
    }
    
     bool isLucky = true;
     
     for (int i = 0; i < nArray.Count; i++)
     {
          if (nArray[i] != 4 && nArray[i] != 7)
          {
               isLucky = false;
               break;
          }
     }
     
     return isLucky;

}
