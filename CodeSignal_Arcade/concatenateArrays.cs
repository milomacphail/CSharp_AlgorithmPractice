int[] concatenateArrays(int[] a, int[] b) {

    List<int> list = new List<int>();
    
    list.AddRange(a);
    list.AddRange(b);
    
    return list.ToArray();
    
}
