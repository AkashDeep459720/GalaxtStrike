using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject PlayerDestroyVFX;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with " + other.gameObject.name);
        Instantiate(PlayerDestroyVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
