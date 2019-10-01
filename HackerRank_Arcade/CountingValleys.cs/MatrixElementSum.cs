using System;


public class Program
{
	public static void Main(string[] args)
	{
        int matrixElementsSum(int[][] matrix)
        {

            int sum = 0;

            for (int col = 0; col < matrix[0].Length; col++)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][col] != 0)
                    {
                        sum += matrix[row][col];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return sum;
        }

    }
}
