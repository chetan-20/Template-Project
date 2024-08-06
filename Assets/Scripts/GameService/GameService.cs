using UnityEngine;

//Service Locator
public class GameService : MonoBehaviour
{
    [SerializeField] private GameObject levelObject;
    [SerializeField] private SoundService soundService;
    [SerializeField] private PopUpService popUpService;
    private static GameService instance;
   
    public SoundService SoundService {  get { return soundService; } }
    public PopUpService PopUpService { get { return popUpService; } }
    public static GameService Instance {  get { return instance; } }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }
    private void Start()
    {
        EnableLevel(false);
    }
    public void EnableLevel(bool status) => levelObject.SetActive(status);
}
