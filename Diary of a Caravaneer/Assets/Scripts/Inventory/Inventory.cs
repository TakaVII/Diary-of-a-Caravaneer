using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(Item item, int quantity = 1)
    {
        InventoryItem existingItem = items.Find(i => i.item == item);
        if (existingItem != null)
        {
            existingItem.quantity += quantity;
        }
        else
        {
            items.Add(new InventoryItem(item, quantity));
        }
    }

    public void RemoveItem(Item item, int quantity = 1)
    {
        InventoryItem existingItem = items.Find(i => i.item == item);
        if (existingItem != null)
        {
            if (existingItem.quantity > quantity)
            {
                existingItem.quantity -= quantity;
            }
            else
            {
                items.Remove(existingItem);
            }
        }
        else
        {
            Debug.LogWarning($"Item {item.itemName} not found in inventory.");
        }
    }

    public InventoryItem GetItem(Item item)
    {
        return items.Find(i => i.item == item);
    }

    public void ListItems()
    {
        foreach (InventoryItem inventoryItem in items)
        {
            Debug.Log($"{inventoryItem.item.itemName} (x{inventoryItem.quantity})");
        }
    }
}

[System.Serializable]
public class InventoryItem
{
    public Item item;
    public int quantity;

    public InventoryItem(Item item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }
}