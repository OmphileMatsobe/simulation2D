using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    public GameObject one, two, three;
    public GameObject oneDisplay, twoDisplay, threeDisplay;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bon")
        {
            one.SetActive(false);
            oneDisplay.SetActive(false);
        }

        if (collision.tag == "Lany")
        {
            two.SetActive(false);
            twoDisplay.SetActive(false);
        }

        if (collision.tag == "Ben")
        {
            three.SetActive(false);
            threeDisplay.SetActive(false);
        }
    }
}
