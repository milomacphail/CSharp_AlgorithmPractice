bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
    
    bool equallyStrong = false;
    
    if (Math.Max(yourLeft, yourRight) == Math.Max(friendsLeft, friendsRight) && (Math.Min(yourLeft, yourRight) == Math.Min(friendsLeft, friendsRight)))
    {
        equallyStrong = true;
    }
    
    return equallyStrong;

}