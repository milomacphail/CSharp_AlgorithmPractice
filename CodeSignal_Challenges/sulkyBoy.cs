bool sulkyBoy(bool statement) {
    
    bool sulky = true;
    
    switch (statement) {
        case true:
            sulky = false;
            break;
            
        case false:
            sulky = true;
            break;
    }

    return sulky;
}
