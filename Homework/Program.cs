using System;

namespace Project{
class TrianglePascal{
public int row;  
const int cellWidth = 5;
public int[,] triangle;
public void FillTriangle(int _row, int[,] _triangle)
{
    row = _row;
    triangle = _triangle;   
    for (int i = 0; i < row; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i,j] = triangle[i - 1,j - 1] + triangle[i - 1,j];
        }
    }
}

public void PrintTriangle()
{
    for (int i = 0; i < row; i++ )
    {
        for (j = 0; j < row; j++)
        {
            if(triangle[i,j] != 0)
                Console.Write($"{triangle[i,j],cellWidth}");

        }
        Console.WriteLine();
    }
}

public void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}


}
}



