using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeGrid : MatrixFunctions
{
    Cell[,] array;
   public TicTacToeGrid(int row, int col, int[,] arr) : base(row,col,arr)
    {
        for(int i = 0; i<row; i++)
        {
            for(int j=0; j<col; j++)
            {
                array[i, j] =new Cell();
            }
        }
    }
}
