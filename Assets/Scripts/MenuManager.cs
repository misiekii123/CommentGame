using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;

    private void Start()
    {
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
