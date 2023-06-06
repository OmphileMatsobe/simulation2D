
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class animalStats : MonoBehaviour
{
    public float mealsPerDay, weight, attentionRate, energyCapacity, amountOfWater;
    public animal animalData;
    TMP_Text HealthText, hungerText;
    public Image hungerBar, EnergyBar, CleanLinessBar, attentionBar, healthBar;
    public float hunger,  hungerTime, health, clean;
    float maxHunger, maxEnergy, maxAttention, maxCleanliness,  maxHealth = 100;
    float lerpSpeed, currentMinutes, currentTime, cleanTime;
    float attentionFactor;

    public void Start()
    {
        StartCoroutine(CountTime());
        
    }

    public void feed()
    {

    }

    public void attention()
    {
        //e.g - every after 3 hours of the game time your animals require attentions.

        

        attentionBar.fillAmount = attentionRate  / maxAttention;
    }

    public void Hunger()
    {
        //e,g - your animals eat twice in a day.

        hunger = (hungerTime / 12 ) * 100;

        hungerBar.fillAmount = hunger / maxHunger;
    }

    //This is the function to calculate the amount of energy the animal has in the body
    public void Energy()
    {
        //if your animals do not get enough food and attention and water, the energy decreases

        EnergyBar.fillAmount = (energyCapacity - hunger ) / maxEnergy; 
    }

    public void cleanliness()
    {
        //you have to clean for your animals ones in evry two days 

        //clean = 100 - ((10 - animalData.cleanliness) * 5 * cleanTime);
        CleanLinessBar.fillAmount = clean / maxCleanliness;
    }


    //the health of the animals is the combination of all the other properties.
    public void Health()
    {

        //attentions, hunger, energy and cleanliness

        health = ((((100 - hunger) + (energyCapacity - hunger) + clean) / 300f) * 100f);
        Debug.Log("Health = " + health);
        Debug.Log("Hunger = " + hunger);
        Debug.Log("energy = " + energyCapacity);
        Debug.Log("clean = " + clean);

        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health/maxHealth, lerpSpeed);
        
    }

    void color()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (health/maxHealth));
        Color hungerColor = Color.Lerp(Color.green, Color.red, (hunger / maxHunger));
        Color attentionColor = Color.Lerp(Color.red, Color.green, (attentionRate / maxAttention));
        Color cleanColor = Color.Lerp(Color.red, Color.green, (clean / maxCleanliness));
        Color energyColor = Color.Lerp(Color.red, Color.green, ((energyCapacity - hunger) / maxEnergy));

        healthBar.color = healthColor;
        hungerBar.color = hungerColor;
        attentionBar.color = attentionColor;
        CleanLinessBar.color = cleanColor;
        EnergyBar.color = energyColor;
    }

    IEnumerator CountTime()
    {
        while (currentMinutes < 60)
        {

            yield return new WaitForSeconds(0.33f * 2);

            currentMinutes++;
            if (currentMinutes == 60)
            {
                currentMinutes = 0;
                currentTime++;
                hungerTime++;
                cleanTime++;

                if (hungerTime == 12)
                {
                    this.gameObject.SetActive(false);
                }

                if (currentTime == 24)
                {
                    currentTime = 0;
                }
            }
        }
    }

    public void Update()
    {
        //   HealthText.text = "Health = " + health + "%";
        // hungerText.text = "Hunger" + hunger + "%";

        

        Hunger();
        Health();
        cleanliness();
        Energy();
        attention();
        color();

        
        lerpSpeed = 3f * Time.deltaTime;
    }
}
