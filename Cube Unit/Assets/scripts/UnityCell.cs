using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityCell : MonoBehaviour
{
    public GameObject[] gameObject;
    Cell cell=new Cell();
    public static int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        SetStatus(Cell.Status.non);
        cell.delegateStatus += SetStatus;
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void SetStatus(Cell.Status status)
    {
        for (int i = 0; i < gameObject.Length; i++) {
            if (i==(int)status)
            {
                gameObject[i].SetActive(true);
            }
            else
            {
                gameObject[i].SetActive(false);
            }
        }
    }
    private void OnMouseDown()
    {
        cell.CellInteraction();
        count++;
    }
}
