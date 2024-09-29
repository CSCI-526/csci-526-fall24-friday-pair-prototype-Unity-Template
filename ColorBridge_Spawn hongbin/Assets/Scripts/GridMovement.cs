using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public float distance = 1.0f;
    private Vector2 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if ((Vector2)transform.position == targetPosition)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                targetPosition += Vector2.up * distance;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                targetPosition += Vector2.down * distance;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                targetPosition += Vector2.left * distance;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                targetPosition += Vector2.right * distance;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, distance * 10);
    }
}
