using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBackground : MonoBehaviour
{
    [SerializeField] GameObject background;
    [SerializeField] float size;

    private void Start()
    {
       for (int i = 0; i < size; i++)
        {
            for (int j = 0;  j < size; j++)
            {
                GameObject grid = Instantiate(background) as GameObject;
                grid.transform.position = new Vector3(i, j, 0f);
                grid.transform.SetParent(this.transform);
            }
        }
    }
}
