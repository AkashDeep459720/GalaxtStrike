using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 100f;


    bool isFiring = false;
    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        ProcessFiring();
        MoveCrossHair();
        MoveTargetPoint();
        AimLasers();
    }

   

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
        
    }
    void MoveCrossHair()
        {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        crosshair.position = mousePosition;
    }

    private void MoveTargetPoint()
    {
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);

    }

    void AimLasers()     {
        foreach (GameObject laser in lasers)
        {
            //laser.transform.LookAt(targetPoint);
            Vector3 fireDirection = targetPoint.position - this.transform.position;
            Quaternion RotationToTarget = Quaternion.LookRotation(fireDirection);
            laser.transform.rotation = RotationToTarget;
        }
    }
}
