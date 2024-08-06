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
    public void EnableLevelOverMenu(bool status)=>levelOverObject.SetActive(status);                       
    public void SetLevelEndText(string text) => levelEndText.text = text;
    private void AssingButtons()
    {
        restartLevelButton.onClick.AddListener(OnRestartClick);
        menuButton.onClick.AddListener(OnMenuClicked);
    }
    private void OnRestartClick()
    {
        EnableLevelOverMenu(false);
        GameService.Instance.EnableLevel(true);
    }
    private void OnMenuClicked()
    {
        EnableLevelOverMenu(false);
        GameService.Instance.GetMenuUiScript().EnableMenu(true);
    }
}
