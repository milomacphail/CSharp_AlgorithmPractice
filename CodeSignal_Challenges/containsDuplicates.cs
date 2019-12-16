bool containsDuplicates(int[] a) {
    
    Array.Sort(a);
    
    for(int i = 0; i < a.Length - 1; i++){
        if(a[i] == a[i + 1]){
            return true;
        }
    }
    return false;
}