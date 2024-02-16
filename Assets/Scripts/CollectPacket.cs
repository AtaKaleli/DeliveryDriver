using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPacket : MonoBehaviour
{

    private bool hasPacket;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Packet" && !hasPacket)
        {
            print("Paket taken");
            Destroy(collision.gameObject);
            hasPacket = true;
        }
        else if(collision.tag == "DeliveryPoint" && hasPacket)
        {
            print("paketDelivered");
            hasPacket = false;
        }
    }


}
