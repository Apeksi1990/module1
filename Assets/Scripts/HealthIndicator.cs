using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthIndicator : MonoBehaviour
{
    public TextMeshProUGUI textField;
    float displayedHealth;
    private CharacterData _characterData;

    // Start is called before the first frame update
    void Start()
    {
        _characterData = GetComponent<Character>().CharacterData;
        displayedHealth = _characterData.Health - 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float value = _characterData.Health;
        if (Mathf.Abs(displayedHealth - value) >= 0.00001f) {
            displayedHealth = value;
            textField.text = $"{value}";
        }
    }
}
