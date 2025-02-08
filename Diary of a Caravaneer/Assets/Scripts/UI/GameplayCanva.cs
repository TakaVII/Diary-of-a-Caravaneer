using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayCanvaController : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private GameObject locationName;
    [SerializeField] private GameObject gameplayButtons;
    [SerializeField] private GameObject bookMenu;
    [SerializeField] private GameObject bookMenuImage;

    [Header("Menu Prefabs")]
    [SerializeField] private GameObject statsMenuPrefab;

    private GameObject currentMenuInstance;

    private void Start()
    {
        InitializeGameplayCanvas();
    }

    private void InitializeGameplayCanvas()
    {
        locationName.SetActive(false);
        gameplayButtons.SetActive(true);
        bookMenu.SetActive(false);
    }

    public void UpdateLocationName(string location)
    {
        if (!string.IsNullOrEmpty(location))
        {
            locationName.SetActive(true);
            locationName.GetComponentInChildren<TextMeshProUGUI>().text = location;
        }
        else
        {
            locationName.SetActive(false);
        }
    }

    public void ShowGameplayButtons(bool show)
    {
        gameplayButtons.SetActive(show);
    }

    public void OpenBookMenu()
    {
        bookMenu.SetActive(true);
        // Optionally switch to a default tab/menu
        SwitchToStatsMenu();
    }

    public void CloseBookMenu()
    {
        bookMenu.SetActive(false);
    }

    public void SwitchToStatsMenu()
    {
        if (currentMenuInstance != null)
        {
            Destroy(currentMenuInstance);
        }

        currentMenuInstance = Instantiate(statsMenuPrefab, bookMenuImage.transform);
    }

    public void UpdateInventoryUI(PlayerInventory playerInventory)
    {
        var inventoryGrid = currentMenuInstance.transform.Find("InventoryMenu/InventoryMenu_Grid").GetComponent<UnityEngine.UI.GridLayoutGroup>();
        if (inventoryGrid != null)
        {
            foreach (Transform child in inventoryGrid.transform)
            {
                Destroy(child.gameObject);
            }

            foreach (var item in playerInventory.items)
            {
                var itemIconInstance = Instantiate(itemIconBasePrefab, inventoryGrid.transform);
                var itemIcon = itemIconInstance.GetComponent<ItemIconBase>();
                itemIcon.SetItemInfo(item);
            }
        }
    }
}