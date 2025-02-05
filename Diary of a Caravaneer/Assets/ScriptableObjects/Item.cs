using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    [SerializeField] public string itemName;
    [SerializeField] public string description;
    [SerializeField] public Sprite icon;
    [SerializeField] public int baseBuyPrice;  // Base price to buy the item
    [SerializeField] public int baseSellPrice; // Base price to sell the item
    [SerializeField] public ItemCategory category; // Enum for item category (e.g., Food, Tool, TradeGood, etc.)
    [SerializeField] public float demandMultiplier = 1.0f; // Item-specific demand multiplier
    [SerializeField] public float eventMultiplier = 1.0f;  // Item-specific event multiplier
}

public enum ItemCategory
{
    Food,
    Tool,
    TradeGood,
    Medicine,
    Weapon,
    Armor
}