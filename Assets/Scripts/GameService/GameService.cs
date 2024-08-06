using UnityEngine;

//Service Locator
public class GameService : MonoBehaviour
{
    [SerializeField] private GameObject levelObject;
    [SerializeField] private SoundService soundService;
    [SerializeField] private PopUpService popUpService;
    [SerializeField] private MenuUiScript menuUiScript;
    [SerializeField] private LevelEndScript levelEndScript;
    private static GameService instance;    
    public static GameService Instance {  get { return instance; } }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        EnableLevel(false);
    }
    public SoundService GetSoundService() => soundService;
    public PopUpService GetPopUpService() => popUpService;
    public MenuUiScript GetMenuUiScript() => menuUiScript;
    public LevelEndScript GetLevelEndScript() => levelEndScript;
    public void EnableLevel(bool status) => levelObject.SetActive(status);
}
