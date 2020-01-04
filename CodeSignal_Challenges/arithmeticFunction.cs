bool arithmeticExpression(int a, int b, int c) {
    
    double aD = Convert.ToDouble(a);
    double bD = Convert.ToDouble(b);
    double cD = Convert.ToDouble(c);
    
    if((aD + bD == cD) || (aD - bD == cD) || (aD * bD == cD) || (aD / bD == cD))
    {
        Console.WriteLine(c);
        return true;
    }
    
    return false;

}
