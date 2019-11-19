int[] removeArrayPart(int[] inputArray, int l, int r) {
    
    int count = (r - l + 1);
    
    List<int> arrayToList = inputArray.ToList();
    arrayToList.RemoveRange(l, count);
    return arrayToList.ToArray();

}
