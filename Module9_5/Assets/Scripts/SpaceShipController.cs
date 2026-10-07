using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotationSpeed = 60f;

    private float moveInput;
    private float rotateInput;

    private void Update()
    {
        MoveShip();
        RotateShip();
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }

    public void Rotate(InputAction.CallbackContext context)
    {
        rotateInput = context.ReadValue<float>();
    }

    private void MoveShip()
    {
        transform.position += transform.forward * moveInput * moveSpeed * Time.deltaTime;
    }

    private void RotateShip()
    {
        transform.Rotate(0f, rotateInput * rotationSpeed * Time.deltaTime, 0f);
    }
}
