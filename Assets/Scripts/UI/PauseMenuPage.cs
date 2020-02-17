using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuPage : MonoBehaviour
{
    public Button PauseButton;
    public GameObject VisualRoot;
    public GameObject BattlePageVisualRoot;
    public Button ResumeButton;
    public Button StartLevelAgainButton;
    public Button GoToMainMenuButton;
    public String MainMenu = "StartMenu";

    void Start()
    {
        VisualRoot.SetActive(false);
        PauseButton.onClick.AddListener(ShowPauseMenu);
        ResumeButton.onClick.AddListener(HidePauseMenu);
        StartLevelAgainButton.onClick.AddListener(StartLevelAgain);
        GoToMainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    void Update()
    {
    }

    private void ShowPauseMenu()
    {
        Time.timeScale = 0;
        BattlePageVisualRoot.SetActive(false);
        VisualRoot.SetActive(true);
    }

    private void HidePauseMenu()
    {
        Time.timeScale = 1;
        BattlePageVisualRoot.SetActive(true);
        VisualRoot.SetActive(false);
    }

    private void StartLevelAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MainMenu);
    }
}
