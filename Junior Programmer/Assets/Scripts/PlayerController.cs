using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float turnSpeed;
    public InputAction action;
    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        action.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        moveInput = action.ReadValue<Vector2>();
        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
