using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToeView : MonoBehaviour
{
    public GameObject[,] array;
    public int row, col;
    private float HorizontalSpacing=1.0f, VerticalSpacing=1.0f;
    public float Horizontal_Spacing, Vertical_Spacing;
    static float temp;
    public GameObject gb;
    int counter = 1;
    public TicTacToeView()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        temp = VerticalSpacing;
        array = new GameObject[row, col];
        for (int i = 0; i < row; i++)
        {
            VerticalSpacing = temp;
            for (int j = 0; j < col; j++)
            {
                array[i, j] = Instantiate(gb, new Vector3(HorizontalSpacing, 0, VerticalSpacing), gb.transform.rotation);
                VerticalSpacing+=Vertical_Spacing;
            }
            HorizontalSpacing +=Horizontal_Spacing;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
