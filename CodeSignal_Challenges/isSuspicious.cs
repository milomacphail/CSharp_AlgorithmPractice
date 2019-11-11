bool isSuspiciousRespondent(bool ans1, bool ans2, bool ans3) {
    
    bool isSuspicious = false;
    
    if(ans1 == ans2 && ans1 == ans3)
    {
        return true;
    }
    
    return isSuspicious;

}
