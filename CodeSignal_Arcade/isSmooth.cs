bool isSmooth(int[] arr) {

    int middle = arr[arr.Length/2];
    
    if(arr.Length %2 == 0)
    {
        middle = (arr[arr.Length/2] + arr[(arr.Length/2)-1]);
    }
    
    Console.WriteLine(middle);
    
    if(arr[0] == arr[arr.Length -1] && arr[0] == middle)
        return true;
    
    else
        return false;
}
