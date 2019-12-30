bool sumOfTwo(int[] a, int[] b, int v) {
    
    var hash = new HashSet<int>(b);
    
    return a.Any(x => hash.Contains(v - x));
    
    
    
}
