using UnityEngine;

//Service Locator
public class GameService : MonoBehaviour
{
    [SerializeField] private SoundService soundService;
    private static GameService instance;
   
    public SoundService SoundService {  get { return soundService; } }
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
}
