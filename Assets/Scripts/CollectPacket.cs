using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPacket : MonoBehaviour
{

    private bool hasPacket;
    private int noOfPackeges = 5;


    private void Update()
    {
        GameUI.instance.ShowRemainingPackeges(noOfPackeges);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Packet" && !hasPacket)
        {
            GameUI.instance.ShowInfo("Package Taken!");
            Destroy(collision.gameObject);
            hasPacket = true;
            DecreasePacketNumber();
        }

        else if (collision.tag == "Packet" && hasPacket)
        {
            GameUI.instance.ShowInfo("First Deliver Already Taken Package!");
            
        }

        else if(collision.tag == "DeliveryPoint" && hasPacket)
        {
            GameUI.instance.ShowInfo("Package Delivered!");
            hasPacket = false;
        }
    }

    private void DecreasePacketNumber() => noOfPackeges--;


}
