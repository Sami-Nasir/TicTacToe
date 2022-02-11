using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixFunctions
{
    public int[,] Matrix;
    public MatrixFunctions(int row, int col,int[,] newArray)
    {
       Matrix = new int[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Matrix[i, j] = 0;
            }
            SetMatrix(newArray);
        }
    }
        public void SetMatrix(int[,] data1)
    {
        for (int i = 0; i<data1.GetLength(0); i++)
        {
            for (int j = 0; j < data1.GetLength(1); j++)
            {
                Matrix[i, j] = data1[i, j];
            }
        }
    }
    public void PrintMatrix()
    {
        string str = "";
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
                str+=Matrix[row, col]+" ";
            }
            str += "\n";
        }
        Debug.Log(str);
    }
    public void AddMatrix(int[,] matrixData)
    {
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
                Matrix[row, col] = Matrix[row, col] + matrixData[row, col];
                PrintMatrix();
            }
        }
    }
    public void GetElement(int x, int y)
    {
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            if (x == row)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (y == col)
                    {
                        Debug.Log(Matrix[row, col]);
                    }
                }
            }
        }
    }
    public void SetElement(int x, int y, int val)
    {
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            if (x == row)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (y == col)
                    {
                        (Matrix[row, col]) = val;
                    }
                }
            }
        }
    }
    public void setRow(int[] arr, int rowNum)
    {
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            if(rowNum==row)
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
               Matrix[row, col] = arr[col];
            }
            
        }
    }
    public void setCol(int[] arr, int colNum)
    {
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if(colNum == col)
                    Matrix[row, col] = arr[row];
                }

        }
    }
    public bool IsRowSame(int rowNum)
    {
        bool isSet = false;
        int count = 0;
        for (int row = 0; row < Matrix.GetLength(0); row++)
        {
            if (rowNum == row)
            {
               
                for (int col = 0; col < Matrix.GetLength(1)-1; col++)
                {
                    if (Matrix[row, col] == Matrix[row, col+1])
                    {
                        count++;
                    }
                }
            }

        }
        if (count == Matrix.GetLength(0)-1)
            isSet = true;
        return isSet;
    }
    public bool IsColSame(int colNum)
    {
        int count = 0;
        bool isSet = false;
        for (int row = 0; row < Matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < Matrix.GetLength(1); col++)
            {
                if (colNum == col)
                {
                     if (Matrix[row, col] == Matrix[row + 1, col])
                     {
                        count++;
                     }
                }
            }
        }
        if (count == Matrix.GetLength(1))
            isSet = true;
        return isSet;
    }
}