using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "animal", menuName = "Scriptable Objects/animal", order = 1)]
public class animal : ScriptableObject
{
    //massInGrams is the mass of the animal
    //EnergyInCalories is the energy required for the enermal to be ina good state
    //mealsPerDay is the recommended number if times the animal should eat 
    //foodMassRequired is the total amount of food reuired for the animal to eat in a day
    //attentioPerDay is the recoomended number of times the animal should get attention  

    public string Name;
    public float massInGrams, EnergyInCalories, cleanliness, mealsPerDay, foodMassRequired, hoursOfSleep;
}