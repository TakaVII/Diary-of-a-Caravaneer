using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemIconBase : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private TMP_Text itemName;
    [SerializeField] private TMP_Text itemQuantity;
    [SerializeField] private TMP_Text itemDescription;
    [SerializeField] private TMP_Text averageMarketPrice;

    public void SetItemInfo(InventoryItem inventoryItem)
    {
        itemIcon.sprite = inventoryItem.item.icon;
        itemName.text = inventoryItem.item.itemName;
        itemQuantity.text = inventoryItem.quantity.ToString();
    }

    public void OnMouseOver()
    {
        // Show additional information or highlight the item
    }

    public void OnMouseExit()
    {
        // Hide additional information or remove highlight
    }
}
