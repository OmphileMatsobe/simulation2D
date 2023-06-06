using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string Name;
    public float Weight;
    public float EnergyPerDay;
    public float FoodPerDay;    
    public float Cleanliness;
    public float MealsPerDay;
    public float HoursOfSleep;

    public Item(Item d)
    {
        Name = d.Name;
        Weight = d.Weight;
        EnergyPerDay = d.EnergyPerDay;
        FoodPerDay = d.FoodPerDay;
        Cleanliness = d.Cleanliness;
        MealsPerDay = d.MealsPerDay;
        HoursOfSleep = d.HoursOfSleep;
    }
}

