using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]GameObject DestroyedVFX;
    private void OnParticleCollision(GameObject other)
    {
        Instantiate(DestroyedVFX, transform.position,Quaternion.identity);
        Destroy(this.gameObject);
    }
}
