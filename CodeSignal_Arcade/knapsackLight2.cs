string knapsackLight2(int weight1, int weight2, int maxW) {
    
    if (weight1 + weight2 <= maxW)
    {
        return "both";
    }
    else if(weight1 <= maxW && weight2 <= maxW && (weight1 + weight2) > maxW)
    {
        return "either";
    }
    else if (weight1 <= maxW && weight2 > maxW)
    {
        return "first";
    }
    else if (weight2 <= maxW && weight1 > maxW)
    {
        return "second";
    }
    else 
    {
        return "none";      
    }

}
