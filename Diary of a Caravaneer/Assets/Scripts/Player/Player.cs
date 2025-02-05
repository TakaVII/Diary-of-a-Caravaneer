using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int gold;
    public PlayerInventory inventory;
    public List<Relationship> townRelationships = new List<Relationship>();
    public List<Relationship> npcRelationships = new List<Relationship>();

    void Start()
    {
        // Initialize player inventory
        inventory = new PlayerInventory();
    }

    public void AddGold(int amount)
    {
        gold += amount;
    }

    public void RemoveGold(int amount)
    {
        if (gold >= amount)
        {
            gold -= amount;
        }
        else
        {
            Debug.LogWarning("Not enough gold.");
        }
    }

    public Relationship GetTownRelationship(string townName)
    {
        return townRelationships.Find(r => r.name == townName);
    }

    public Relationship GetNpcRelationship(string npcName)
    {
        return npcRelationships.Find(r => r.name == npcName);
    }
}