using System;

static bool MatrixCheck(int[,] matrix, int n)
{
    if (n > 0 && n < 3)
        return true;

    int numberOfNegativeElementsInRow = 0;
    int numberOfCorrectRows = 0;

    for (int row = 0; row < n; row++)
    {
        for (int column = 0; column < n; column++)
        {
            if (matrix[row, column] < 0)
                numberOfNegativeElementsInRow++;
        }

        if (numberOfNegativeElementsInRow <= 2)
        {
            numberOfCorrectRows++;
            break;
        }
        numberOfNegativeElementsInRow = 0;
    }

    return numberOfCorrectRows > 0;
}


int[,] matrix = { 
    { -1, -2, -3}, 
    { 4, -5, -6}, 
    { 7, -8, -9},
};

Console.WriteLine(MatrixCheck(matrix, 3));
