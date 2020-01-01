bool isLucky(int n) {

    var firstHalf = n.ToString().Substring(0, n.ToString().Length / 2).Sum(x=>Convert.ToInt32(x));
    var secondHalf = n.ToString().Substring(n.ToString().Length / 2).Sum(x => Convert.ToInt32(x));
    
    return firstHalf.Equals(secondHalf);

}


