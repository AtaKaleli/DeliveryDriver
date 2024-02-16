using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed;


    void Update()
    {
        float steerInput = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerInput);
        transform.Translate(0, moveInput, 0);
    }
}
