using UnityEngine;

public class HitSoundPlayer : MonoBehaviour
{
    public AudioClip StandartHit;
    public AudioClip ShootHit;
    public AudioClip HandHit;

    public void StandartHitPlay()
    {
        SFXManager.Instance.Play(StandartHit, transform.position);
    }

    public void ShootHitPlay()
    {
        SFXManager.Instance.Play(ShootHit, transform.position);
    }

    public void HandHitPlay()
    {
        SFXManager.Instance.Play(HandHit, transform.position);
    }
}
