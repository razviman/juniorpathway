using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    public InputAction verticalInputAction;

    private Vector3 verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        verticalInputAction.Enable();
    }

    // Update is called once per frame (aici punem input-ul și mișcarea non-fizică)
    void Update()
    {
        // GetAxisRaw asigură că primești doar -1, 0 sau 1, fără efect de "alunecare"
        verticalInput = verticalInputAction.ReadValue<Vector3>();

        // Mișcăm avionul în față cu o viteză constantă
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Avionul se înclină doar dacă verticalInput este diferit de 0 (adică apeși tasta)
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * verticalInput.y);
    }
}