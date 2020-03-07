using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSoundPlayer : MonoBehaviour
{
    public AudioClip[] StepsSound;

    public void StepPlay()
    {
        int sound = Random.Range(0, StepsSound.Length);
        SFXManager.Instance.Play(StepsSound[sound], transform.position);
    }
}
