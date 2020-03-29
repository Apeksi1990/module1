using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterData", menuName = "Character Data", order = 51)]
public class CharacterData : ScriptableObject
{
    [SerializeField] private float health;
    [SerializeField] private float damage;

    public float Health
    {
        get => health;
        set => health = value;
    }

    public float Damage
    {
        get => damage;
        set => damage = value;
    }

    public void ApplyDamage(float damage)
    {
        health -= damage;
    }
}
