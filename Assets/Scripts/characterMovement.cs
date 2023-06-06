using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class characterMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    float hor, ver;
    public float attentionFac, F;
    Vector2 playerPos;

    public GameObject displayOne, displayTwo, displayThree;
    public Animator animation;

    public void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "chickenTag")
        {
            displayOne.SetActive(true);
        }
        else if (collider.tag == "rabbitTag")
        {
            displayTwo.SetActive(true);
        }
        else if (collider.tag == "sheepTag")
        {
            displayThree.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {

        if (collider.tag == "chickenTag")
        {
            displayOne.SetActive(false);
        }
        else if (collider.tag == "rabbitTag")
        {
            displayTwo.SetActive(false);
        }
        else if (collider.tag == "sheepTag")
        {
            displayThree.SetActive(false);
        }
    }

        public void Update()
    {
        F = attentionFac;

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        Debug.Log(hor + "This is hor");
        Debug.Log(ver + "This is ver");

        playerPos = transform.position;
    
        playerPos.x += hor * speed * Time.deltaTime;
        playerPos.y += ver * speed * Time.deltaTime;

        AnimateMovement(playerPos);

        transform.position = playerPos;
    }

    void AnimateMovement(Vector2 direction)
    {
        if (animation != null)  
        { 
            if( hor != 0 || ver != 0)
            {
                animation.SetBool("isMoving", true);
                animation.SetFloat("horizontal", hor);
                animation.SetFloat("vertical", ver);
            }
            else 
            {
                animation.SetBool("isMoving", false);
            }
        }

    }
}
