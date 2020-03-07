using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSoundPlay : MonoBehaviour
{
    private Button button;
    public AudioClip ClickSound;
    void Start()
    {
        button = GetComponentInParent<Button>();
        button.onClick.AddListener(Play);
    }

    // Update is called once per frame
    private void Play()
    {
        SFXManager.Instance.Play(ClickSound, transform.position);
    }
}
