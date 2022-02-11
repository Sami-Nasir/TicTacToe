using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    public bool var = false;
    int rows;
    int cols;
    public enum Status
    {
        non,
        circle,
        cross,
        loose,
        win
    };
    Status status;

    public delegate void DelegateStatusUpdate(Status status);
    public DelegateStatusUpdate delegateStatus;
    public Cell() 
    {
        rows = 0;
        cols = 0;
        status = Status.non;
    }
    public void SetStatus(Status sts)
    {
        this.status = sts;
        delegateStatus.Invoke(status);
    }
    public Status GetStatus()
    {
        return status;
    }
    public void SetRowCol(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
    }
    public int GetRow()
    {
        return rows;
    }
    public int GetCol()
    {
        return cols;
    }
    public void CellInteraction()
    {
        if (UnityCell.count % 2==0){ 
        SetStatus(Status.cross);
        }
        else
        {
          SetStatus(Status.circle);
        }
    }
}
