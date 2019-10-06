bool reachNextLevel(int experience, int threshold, int reward) {
    
    bool didReach = false;
    
    if(experience + reward >= threshold)
    {
        didReach = true;
    }

    return didReach;
}
