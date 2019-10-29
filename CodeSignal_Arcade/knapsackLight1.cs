int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW) {
    
    int maxValue = 0;
    
    if(weight1 + weight2 <= maxW)
    {
        maxValue = (value1 + value2);
        Console.WriteLine("{0}{1}", weight1, weight2);
    }
    else if (value1 >= value2 && weight1 < maxW && (weight1 + weight2) > maxW)
    {
        maxValue = Math.Max(value2, value1);
        Console.WriteLine(weight1);
    }
    else if (value2 >= value1 && weight2 < maxW && (weight2 + weight1) > maxW)
    {
        maxValue = Math.Max(value2, value1);
        Console.WriteLine(weight2);
    }
    else if (weight2 > maxW && weight1 <= maxW)
    {
        return value1;
    }
    else if  (weight1 > maxW && weight2 <= maxW)
    {
        return value2;
    }
    else if(weight1 == weight2 && value1 == value2)
    {
      return value1;   
    }
    
    return maxValue;
    
    
}
