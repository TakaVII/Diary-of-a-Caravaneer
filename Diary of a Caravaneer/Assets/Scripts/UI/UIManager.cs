using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("UI Canvases")]
    [SerializeField] public GameObject mainUICanvas;
    [SerializeField] public GameObject mainMenuCanvas;

    [Header("UI Prefabs")]
    [SerializeField] public GameObject gameplayCanvaPrefab;

    [Header("UI Elements Status")]
    [SerializeField] private bool showLocation;
    [SerializeField] private bool showGameplayButtons;
    [SerializeField] private bool showBookMenu;
    [SerializeField] private bool showStatsMenu;

    private GameObject gameplayCanvasInstance;
    private GameplayCanvaController gameplayCanvaController;

    private void Awake()
    {
        // Singleton pattern to ensure only one instance of UIManager exists
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ShowGameplayCanvas();
    }

    public void ShowGameplayCanvas()
    {
        if (gameplayCanvasInstance == null)
        {
            gameplayCanvasInstance = Instantiate(gameplayCanvaPrefab);
            DontDestroyOnLoad(gameplayCanvasInstance);
            gameplayCanvaController = gameplayCanvasInstance.GetComponent<GameplayCanvaController>();
        }
        gameplayCanvasInstance.SetActive(true);
    }

    public void HideGameplayCanvas()
    {
        if (gameplayCanvasInstance != null)
        {
            gameplayCanvasInstance.SetActive(false);
        }
    }

    public void UpdateLocationName(string locationName)
    {
        gameplayCanvaController.UpdateLocationName(locationName);
    }

    public void SetShowGameplayButtons(bool show)
    {
        gameplayCanvaController.ShowGameplayButtons(show);
    }

    public void OpenBookMenu()
    {
        gameplayCanvaController.OpenBookMenu();
    }

    public void CloseBookMenu()
    {
        gameplayCanvaController.CloseBookMenu();
    }

    public void SwitchToStatsMenu()
    {
        gameplayCanvaController.SwitchToStatsMenu();
    }

    public void UpdateInventoryUI(PlayerInventory playerInventory)
    {
        gameplayCanvaController.UpdateInventoryUI(playerInventory);
    }

    public bool ShowLocation
    {
        get => showLocation;
        set
        {
            showLocation = value;
            gameplayCanvaController.UpdateLocationName(value ? "Location Name" : null); // Update this line
        }
    }

    public bool ShowGameplayButtons
    {
        get => showGameplayButtons;
        set
        {
            showGameplayButtons = value;
            SetShowGameplayButtons(value);
        }
    }

    public bool ShowBookMenu
    {
        get => showBookMenu;
        set
        {
            showBookMenu = value;
            if (value) OpenBookMenu();
            else CloseBookMenu();
        }
    }

    public bool ShowStatsMenu
    {
        get => showStatsMenu;
        set
        {
            showStatsMenu = value;
            if (value) SwitchToStatsMenu();
        }
    }
}