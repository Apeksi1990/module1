using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackgroundSoundController : MonoBehaviour
{
    public AudioClip[] Clips;
    public AudioSource BackgroundAudioSource;

    void Start()
    {
        int randomClip = Random.Range(0, Clips.Length);
        BackgroundAudioSource.clip = Clips[randomClip];
        BackgroundAudioSource.Play();
    }

    public void StopBackgroundSound()
    {
        BackgroundAudioSource.Stop();
    }
}
