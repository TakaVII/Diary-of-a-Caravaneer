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
    [SerializeField] public bool showLocation;
    [SerializeField] public bool showGameplayButtons;
    [SerializeField] public bool showBookMenu;
    [SerializeField] public bool showStatsMenu;


    private GameObject gameplayCanvasInstance;

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

    }

    public void ShowGameplayCanvas()
    {
        if (gameplayCanvasInstance == null)
        {
            gameplayCanvasInstance = Instantiate(gameplayCanvaPrefab);
            DontDestroyOnLoad(gameplayCanvasInstance);
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
}