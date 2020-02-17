using System;
using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGamePage : MonoBehaviour
{
    public Text ResultText;
    public Button GoToMainMenuButton;
    public GameObject BattlePageVisualRoot;
    public String MainMenu = "StartMenu";
    public GameObject VisualRoot;

    void Start()
    {
        VisualRoot.SetActive(false);
        GoToMainMenuButton.onClick.AddListener(GoToMainMenu);
    }


    private void GoToMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void ShowEndGamePage(String result)
    {
        BattlePageVisualRoot.SetActive(false);
        VisualRoot.SetActive(true);
        ResultText.text = result;
    }


}
