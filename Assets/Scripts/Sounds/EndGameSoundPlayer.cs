using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSoundPlayer : MonoBehaviour
{
    public AudioClip WinSound;
    public AudioClip LoseSound;
    public BackgroundSoundController BackgroundSoundController;

    public void PlaySound(bool win)
    {
        BackgroundSoundController.StopBackgroundSound();
        if (win)
        {
            SFXManager.Instance.Play(WinSound, transform.position);
        }
        else
        {
            SFXManager.Instance.Play(LoseSound, transform.position);
        }
    }
}
