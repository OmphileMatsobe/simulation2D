using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class loadExcel : MonoBehaviour
{
    public Item blankItem;
    public List<Item> items = new List<Item>();

    public void LoadData()
    {

        items.Clear();

        //Reads File

        List<Dictionary<string, object>> data = CSVReader.Read("Animal");

        for(var i =  0; i < data.Count; i++)
        {
            string Name = data[i]["Name"].ToString();
            float Weight = float.Parse(data[i]["Weight"].ToString(), System.Globalization.NumberStyles.Float);
            float EnergyPerDay = float.Parse(data[i]["Name"].ToString(), System.Globalization.NumberStyles.Float);
            float FoodPerDay = float.Parse(data[i]["Name"].ToString(), System.Globalization.NumberStyles.Float);
            float Cleanliness = float.Parse(data[i]["Name"].ToString(), System.Globalization.NumberStyles.Float);
            float MealsPerDay = float.Parse(data[i]["Name"].ToString(), System.Globalization.NumberStyles.Float);
            float HoursOfSleep = float.Parse(data[i]["Name"].ToString(), System.Globalization.NumberStyles.Float);
        }
    }

    void AddItem(string Name, float Weight, float EnergyPerDay, float FoodPerDay, float Cleanliness, float MealsPerDAy, float HoursOfSleep)
    {
        Item tmpItem = new Item(blankItem);

        tmpItem.Name = Name;
        tmpItem.Weight = Weight;
        tmpItem.EnergyPerDay = EnergyPerDay;
        tmpItem.FoodPerDay = FoodPerDay;
        tmpItem.Cleanliness = Cleanliness;
        tmpItem.MealsPerDay = MealsPerDAy;
        tmpItem.HoursOfSleep = HoursOfSleep;
    }
}*/
