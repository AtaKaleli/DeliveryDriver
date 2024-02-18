using UnityEngine;

public class CornerCarMovement : MonoBehaviour
{



    [SerializeField] private float steerSpeed;
    [SerializeField] private float moveSpeed;


    void Update()
    {
        transform.Rotate(0, 0, steerSpeed*Time.deltaTime*100);
        transform.Translate(0, moveSpeed*Time.deltaTime*100, 0);
    }

}
