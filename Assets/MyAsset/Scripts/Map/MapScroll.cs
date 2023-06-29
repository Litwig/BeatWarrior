using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapScroll : MonoBehaviour
{
    [SerializeField]
    private float ScrollSpeed;

    [SerializeField]
    private float StartPosition;

    [SerializeField]
    private float EndPosition;

    public bool isReroll = false;
    public bool isGameOver = false;
    void Update()
    {
        transform.Translate(-1 * ScrollSpeed * Time.deltaTime, 0, 0);
        ScrollSpawn();
        ScrollEnd();
    }

    private void ScrollSpawn()
    {
        if (transform.position.x <= EndPosition) 
        {
            transform.position = new Vector3(StartPosition, 0, 0);
            isReroll = true;
        }
    }

    private void ScrollEnd()
    {
        if(isGameOver==true)
        {
            ScrollSpeed -= Time.deltaTime;
            
            if(ScrollSpeed <= 0)
            {
                return;
            }
        }
    }
}
