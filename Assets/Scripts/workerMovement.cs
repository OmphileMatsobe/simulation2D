using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workerMovement : MonoBehaviour
{
    public GameObject display, spawnPoint, travel, animal, start;
    GameObject point;
    public float speed;
    int y = 0,x = 0;
    Vector2 AI;


    public void Start()
    {
        if (this.transform.position == start.transform.position)
        {
            x = 0;
        }
    }

    public void moveTowards()
    {
        if ( x == 0)
        {
            point = spawnPoint;
        }
        else if ( x == 1) 
        {
            point = travel;
        }
        else if (x == 2)
        {
            point = animal;
        }   
    }

    public void moveBack()
    {
        if (x == 3)
        {
            point = travel;
            display.SetActive(true);
           
        }
        else if (x == 2)
        {
            point = spawnPoint;
        }
        else if (x == 1)
        {
            point = start;
        }
        else if (x == 0)
        {
            point = start;
            display.SetActive(false);
            this.gameObject.SetActive(false);

        }
    }

    public void feedBackCancel()
    {
        
        this.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (y == 0)
        {
            moveTowards();
        }

        else if (y == 1)
        {
            Invoke("moveBack", 20f);
        }

        AI = Vector2.MoveTowards(transform.position, point.transform.position, speed * Time.deltaTime);

        transform.position = AI;

        if (this.transform.position == start.transform.position)
        {
            y = 0;
            x = 0;
        }
        if (this.transform.position == spawnPoint.transform.position)
        {
            x = 1;
        }

        if (this.transform.position == travel.transform.position)
        {
            x = 2;
        }

        if (this.transform.position == animal.transform.position)
        {
            x = 3;
            y = 1;
        }

    }
}
