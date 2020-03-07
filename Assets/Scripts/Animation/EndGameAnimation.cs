using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameAnimation : MonoBehaviour
{
    public GameObject EndGamePanel;
    public Text EndGameText;
    public GameObject ButtonPanel;

    public void ShowEndGameText(String text)
    {
        ButtonPanel.SetActive(false);
        EndGameText.text = text;
        EndGamePanel.SetActive(true);
    }
}
