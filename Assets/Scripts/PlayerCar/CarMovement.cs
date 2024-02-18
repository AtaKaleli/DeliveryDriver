using UnityEngine;

public class CarMovement : MonoBehaviour
{

    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        transform.position = new Vector3(-8.22f, -0.7f, 0);
    }

    void Update()
    {
        float steerInput = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (moveInput>0)
            transform.Rotate(0, 0, -steerInput);
        else
            transform.Rotate(0, 0, steerInput);

        transform.Translate(0, moveInput, 0);

        
    }
}
