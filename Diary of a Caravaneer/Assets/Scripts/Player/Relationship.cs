using UnityEngine;

[System.Serializable]
public class Relationship
{
    public string name; // Name of the town or NPC
    public int affinity; // Relationship level

    public Relationship(string name, int affinity)
    {
        this.name = name;
        this.affinity = affinity;
    }

    public void IncreaseAffinity(int amount)
    {
        affinity += amount;
    }

    public void DecreaseAffinity(int amount)
    {
        affinity -= amount;
    }
}