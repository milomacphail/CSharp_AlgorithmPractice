bool isGeometricProgression(int[] sequence) {
    
    Array.Sort(sequence);
    
    bool isGeo = true;
    
    var commonFactor = sequence[1] / sequence[0];
    Console.WriteLine(commonFactor);
    
    for(int i = 1; i < sequence.Length; i++)
    { 
        if(sequence[i]/sequence[i-1] != commonFactor)
        {
            isGeo = false;
            break;
        }
    }
    
    return isGeo;
    
}
