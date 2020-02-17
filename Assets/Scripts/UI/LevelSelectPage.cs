using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectPage : MonoBehaviour
{
    public String[] LevelName;
    public GameObject VisualPart;
    public Button FirstLevel;
    public Button SecondLevel;
    public LoadingLogicPage LoadingLogicPage;


    void Awake()
    {
        VisualPart.SetActive(false);
        FirstLevel.onClick.AddListener(() => LoadingLogicPage.LoadScene(LevelName[0]));
        SecondLevel.onClick.AddListener(() => LoadingLogicPage.LoadScene(LevelName[1]));
    }

    public void ShowLevelSelect()
    {
        VisualPart.SetActive(true);
    }

}
