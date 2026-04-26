using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject PlayerDestroyVFX;

    GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
       gameSceneManager.ReloadLeel();
        Debug.Log("Collided with " + other.gameObject.name);
        Instantiate(PlayerDestroyVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
