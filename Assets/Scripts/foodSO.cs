using UnityEngine;

[CreateAssetMenu(fileName = "foodSO", menuName = "Scriptable Objects/Food Info", order = 1)]
public class foodSO : ScriptableObject
{
    public string Name;
    public float Weight, EnergyDensity;
    
}
