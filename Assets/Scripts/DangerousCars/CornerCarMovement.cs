using UnityEngine;

public class CornerCarMovement : MonoBehaviour
{



    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed;


    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }

}
