using UnityEngine;

[CreateAssetMenu(fileName = "New NPC", menuName = "Characters/NPC")]
public class NPC : ScriptableObject
{
    [SerializeField] public string npcName;
    [SerializeField] public int relationshipValue;
    [SerializeField] public bool questCompleted;
    [SerializeField] public Sprite portrait;
    [SerializeField] public Inventory inventory;
    [SerializeField] public string description;

    // Method to increase the relationship value
    public void IncreaseRelationship(int amount)
    {
        relationshipValue += amount;
    }

    // Method to decrease the relationship value
    public void DecreaseRelationship(int amount)
    {
        relationshipValue -= amount;
    }
}