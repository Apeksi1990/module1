using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamagePlayer : MonoBehaviour
{
    public AudioClip[] TakeDamageSound;
    public AudioClip[] DieSound;

    public void TakeDamagePlay()
    {
        int sound = Random.Range(0, TakeDamageSound.Length);
        SFXManager.Instance.Play(TakeDamageSound[sound], transform.position);
    }

    public void DiePlay()
    {
        int sound = Random.Range(0, DieSound.Length);
        SFXManager.Instance.Play(DieSound[sound], transform.position);
    }
}
