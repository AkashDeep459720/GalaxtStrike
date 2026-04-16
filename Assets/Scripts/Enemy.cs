using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]GameObject DestroyedVFX;
    [SerializeField] int hitpoints = 5;
    [SerializeField] int scoreValue = 10;

    Scoreboard scoreboard;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }

    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitpoints = hitpoints - 1;

        if (hitpoints <= 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(DestroyedVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
