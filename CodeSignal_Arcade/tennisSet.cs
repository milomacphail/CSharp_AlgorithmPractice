bool tennisSet(int score1, int score2) {
    
    bool gameWon = false;

    if (score1 == 6 && score2 <= 4 || score2==6 && score1 <= 4 || score1 == 7 && score2 <=6 && score2 >= 5 || score2 == 7 && score1 <=6 && score1 >= 5)
    {
        gameWon = true;
    }
    
    return gameWon;
}
