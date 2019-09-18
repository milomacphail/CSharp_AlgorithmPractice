bool rightTriangle(int[] sides) {
    
    Array.Sort(sides);
    
    bool isRightTriangle =  false;
    
    for(int i = 0; i < sides.Length; i++)
    {
        Console.WriteLine(sides[i]);
        
        if(((sides[0] * sides[0]) + (sides[1] * sides[1])) == (sides[2] * sides[2]))
        {
            isRightTriangle = true;
        }
        
    }
    
    return isRightTriangle;
    
}
