int growingPlant(int upSpeed, int downSpeed, int desiredHeight) {
    
    int height = 0;
    int days = 0;
    
    while(height < desiredHeight)
    {
        
        days++;
        height += upSpeed;
        
        if (height >= desiredHeight)
        {
            break;
        }

        height -= downSpeed;
    }
    
    return days;
}
