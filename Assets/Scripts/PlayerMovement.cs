using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float controlSpeed = 10f;
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float xClampRange = 25f;
    [SerializeField] float yClampRange = 25f;
    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }


    public void OnMove(InputValue value)
    {
      movement = value.Get<Vector2>();
    }
    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampRange, +xClampRange);
        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampRange, +yClampRange);

        transform.localPosition = new Vector3(clampedXPos ,clampedYPos, 0f);
    }
}
