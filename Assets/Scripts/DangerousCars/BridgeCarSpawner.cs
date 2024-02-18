using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCarSpawner : MonoBehaviour
{

    [SerializeField] private BoxCollider2D boxCD;
    [SerializeField] private GameObject bridgeCarPrefab;
    private float timer;
    private float spawnCoolDown = 4;

    void Start()
    {
        timer = spawnCoolDown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            GameObject newCar = Instantiate(bridgeCarPrefab);
            float randomY = Random.Range(boxCD.bounds.min.y, boxCD.bounds.max.y);
            newCar.transform.position = new Vector3(transform.position.x, randomY);
            newCar.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100,0));
            Destroy(newCar, 13);
            timer = spawnCoolDown;
        }


    }
}
