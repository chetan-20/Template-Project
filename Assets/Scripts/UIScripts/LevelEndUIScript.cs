using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelEndScript : MonoBehaviour
{
    [SerializeField] private GameObject levelOverObject;
    [SerializeField] private TextMeshProUGUI levelEndText;
    [SerializeField] private Button restartLevelButton;
    [SerializeField] private Button menuButton;
    private void Awake()
    {
        levelOverObject.SetActive(false);
    }
    private void Start()
    {
        AssingButtons();
    }
    public void OnLevelOver()=>levelOverObject.SetActive(true);                       
    public void SetLevelEndText(string text) => levelEndText.text = text;
    private void AssingButtons()
    {
        restartLevelButton.onClick.AddListener(OnRestartClick);
        menuButton.onClick.AddListener(OnMenuClicked);
    }
    private void OnRestartClick()
    {
        levelOverObject.SetActive(false);
        GameService.Instance.EnableLevel(true);
    }
    private void OnMenuClicked()
    {
        levelOverObject.SetActive(false);
        GameService.Instance.GetMenuUiScript().EnableMenu(true);
    }
}
