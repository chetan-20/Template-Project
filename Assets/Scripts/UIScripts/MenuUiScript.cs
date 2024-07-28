using UnityEngine;
using UnityEngine.UI;

public class MenuUiScript : MonoBehaviour
{   
    [SerializeField] private GameObject menuObject;
    [SerializeField] private Button playButton;
    [SerializeField] private Button muteButton;
    [SerializeField] private Button quitButton;

    private void Start()
    {
        SetMenuButtons();
    }
    private void SetMenuButtons()
    {
        playButton.onClick.AddListener(OnPlayClicked);
        quitButton.onClick.AddListener(OnQuitClicked);
        muteButton.onClick.AddListener(OnMuteClicked);
    }
    private void EnableMenu(bool status) => menuObject.SetActive(status);
    private void OnPlayClicked() => EnableMenu(false);
    private void OnQuitClicked() => Application.Quit();
    private void OnMuteClicked() { }
}
