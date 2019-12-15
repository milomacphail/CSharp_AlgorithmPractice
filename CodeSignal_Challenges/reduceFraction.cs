int[] fractionReducing(int[] fraction) {
    
    if(fraction[0] > fraction[1])
    {
        return fraction;
    }
    
    else {
           fraction[1] = fraction[1]/fraction[0];
           fraction[0] = fraction[0]/fraction[0];
       }
              
       return fraction;
    }
}