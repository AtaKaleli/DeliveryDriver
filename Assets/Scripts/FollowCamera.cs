using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject playerCar;

    // Update is called once per frame

    private void LateUpdate()
    {

        transform.position = playerCar.transform.position + new Vector3(0, 0, -10);

    }


}
