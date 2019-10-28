int matrixTrace(int[][] matrix) {
    
    int sum = 0;
    
    for (int i = 0; i < matrix.Length; i++)
    {
        sum += matrix[i][i];
    }

    return sum;
}
