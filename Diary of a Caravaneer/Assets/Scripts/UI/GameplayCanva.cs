using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayCanvaController : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private GameObject locationName;
    public string location;
    [SerializeField] private GameObject gameplayButtons;
    [SerializeField] private GameObject bookMenu;
    [SerializeField] private GameObject bookMenuImage;

    [Header("Menu Prefabs")]
    [SerializeField] private GameObject statsMenuPrefab;

    private void Start()
    {

    }

    public void ShowLocationName(string location)
    {
        locationName.SetActive(true);
        locationName.GetComponentInChildren<TextMeshProUGUI>().text = location;
    }

    public void HideLocationName()
    {
        locationName.SetActive(false);
    }

    public void ShowGameplayButtons()
    {
        gameplayButtons.SetActive(true);
    }

    public void HideGameplayButtons()
    {
        gameplayButtons.SetActive(false);
    }

}
