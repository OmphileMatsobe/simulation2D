using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;



public class spreadsheetReader : MonoBehaviour
{

    public TextAsset spreadsheetAsset;

    [System.Serializable]
    public class animal
    {
        public string name;
        public int weight;
        public int EnergyPerDay;
        public int mealPerDay;
        public int foodPerDay;
        public int sleepPerDay;
        public int cleanliness;
    }

    [System.Serializable]
    public class animalList
    {
        public animal[] animal;
    }

    public animalList farmAnimalList = new animalList();

    // Start is called before the first frame update
    void Start()
    {
        ReadFile();
    }


    void ReadFile()
    {
        string[] data = spreadsheetAsset.text.Split(new string[] {",","\n"}, StringSplitOptions.None);

        int tableSize = data.Length/7 - 1;
        farmAnimalList.animal = new animal[tableSize];

        for (int i = 0; i < tableSize; i++)
        {
            farmAnimalList.animal[i] = new animal();
            farmAnimalList.animal[i].name = data[7 * (i + 1)];
            farmAnimalList.animal[i].weight = int.Parse(data[7 * (i + 1) + 1]);
            farmAnimalList.animal[i].EnergyPerDay = int.Parse(data[7 * (i + 1) + 2]);
            farmAnimalList.animal[i].foodPerDay = int.Parse(data[7 * (i + 1) + 3]);
            farmAnimalList.animal[i].cleanliness = int.Parse(data[7 * (i + 1) + 4]);
            farmAnimalList.animal[i].mealPerDay = int.Parse(data[7 * (i + 1) + 5]);
            farmAnimalList.animal[i].sleepPerDay = int.Parse(data[7 * (i + 1) + 6]);
        }
    }
}

/*
public class CSVReader
{
    static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
    static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    static char[] TRIM_CHARS = { '\"' };

    public static List<Dictionary<string, object>> Read(string file)
    {
        var list = new List<Dictionary<string, object>>();
        TextAsset data = Resources.Load(file) as TextAsset;

        var lines = Regex.Split(data.text, LINE_SPLIT_RE);

        if (lines.Length <= 1) return list;

        var header = Regex.Split(lines[0], SPLIT_RE);
        for (var i = 1; i < lines.Length; i++)
        {

            var values = Regex.Split(lines[i], SPLIT_RE);
            if (values.Length == 0 || values[0] == "") continue;

            var entry = new Dictionary<string, object>();
            for (var j = 0; j < header.Length && j < values.Length; j++)
            {
                string value = values[j];
                value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
                object finalvalue = value;
                int n;
                float f;
                if (int.TryParse(value, out n))
                {
                    finalvalue = n;
                }
                else if (float.TryParse(value, out f))
                {
                    finalvalue = f;
                }
                entry[header[j]] = finalvalue;
            }
            list.Add(entry);
        }
        return list;
    }
}
*/