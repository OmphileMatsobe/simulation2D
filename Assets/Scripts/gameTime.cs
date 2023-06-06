using System.Collections;
using TMPro;
using UnityEngine;


public class gameTime : MonoBehaviour
{
    
    public TMP_Text textDisplay;

    [SerializeField]
    int currentTime, currentMinutes;
    int chicken, rabbit, sheep;
    public int hunger;
    public bool hungerStrikeChick, hungerStrikeRabbit, hungerStrikeSheep, hungerStrike;
    public float Feed = 0;

    [SerializeField]
    GameObject workerOne, workerTwo, workerThree;

    
    private void Start()
    {
        StartCoroutine(CountdownMinutes());
        chicken = rabbit = sheep = 0;

        hungerStrikeChick = hungerStrikeRabbit = hungerStrikeSheep = false;
    }

    IEnumerator CountdownMinutes()
    {

        while (currentMinutes < 60)
        {

            yield return new WaitForSeconds(0.33f * 2);

            currentMinutes++;
            if (currentMinutes == 60)
            {
                currentMinutes = 0;
                currentTime++;

                if (currentTime == 24) 
                {
                    currentTime = 0;
                }
            }
        }
    }

    public void checkHunger()
    {
        float x = gameObject.GetComponent<animalStats>().hunger;
        if (hunger <= 60)
        {
            Feed = 1;
        }

        if (hunger > 60)
        {
            Feed = 1;
        }
    }
    private void hungerTimeCalculator()
    {
        if (currentMinutes == 60)
        {
            chicken++;
            sheep++;
            rabbit++;

            //hunger
            if (chicken == 8)
            {
                hungerStrikeChick = true;
            }

            if (sheep == 6)
            {
                hungerStrikeSheep = true;
            }

            if (rabbit == 8)
            {
                hungerStrikeRabbit = true;
            }

            //attention
            if (chicken == 8)
            {
                hungerStrikeChick = true;
            }

            if (sheep == 6)
            {
                hungerStrikeSheep = true;
            }

            if (rabbit == 8)
            {
                hungerStrikeRabbit = true;
            }

            //attention
            if (chicken == 8)
            {
                hungerStrikeChick = true;
            }

            if (sheep == 6)
            {
                hungerStrikeSheep = true;
            }

            if (rabbit == 8)
            {
                hungerStrikeRabbit = true;
            }

            //energy
            if (chicken == 8)
            {
                hungerStrikeChick = true;
            }

            if (sheep == 6)
            {
                hungerStrikeSheep = true;
            }

            if (rabbit == 8)
            {
                hungerStrikeRabbit = true;
            }

            //
            if (chicken == 8)
            {
                hungerStrikeChick = true;
            }

            if (sheep == 6)
            {
                hungerStrikeSheep = true;
            }

            if (rabbit == 8)
            {
                hungerStrikeRabbit = true;
            }
        }
    }

    public void Update()
    {
        if (currentTime == 6 && currentMinutes == 0)
        {
            workerOne.SetActive(true);
        }

        else if (currentTime == 6 && currentMinutes == 20 )
        {
            workerTwo.SetActive(true);
        }

        else if (currentTime == 8 && currentMinutes == 20)
        {
            workerThree.SetActive(true);
        }

        else if (currentTime == 4 && currentMinutes == 0)
        {
            workerOne.SetActive(true);
        }

        else if (currentTime == 6 && currentMinutes == 0)
        {
            workerTwo.SetActive(true);
        }

        else if (currentTime == 4 && currentMinutes == 20)
        {
            workerThree.SetActive(true);
        }


        if (currentTime < 10)
        {
            if (currentMinutes < 10)
            {
                textDisplay.text = "0" + currentTime.ToString() + ":" + "0" + currentMinutes.ToString();
            }
            else
            {
                textDisplay.text = "0" + currentTime.ToString() + ":" + currentMinutes.ToString();
            }
        }
        else
        {
            if (currentMinutes < 10)
            {
                textDisplay.text =  currentTime.ToString() + ":" + "0" + currentMinutes.ToString();
            }
            else
            {
                textDisplay.text =  currentTime.ToString() + ":" + currentMinutes.ToString();
            }  
        }
    }
}
