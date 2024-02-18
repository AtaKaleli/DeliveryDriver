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
            GameAudio.instance.PlayPackageTaken();
            Destroy(collision.gameObject);
            hasPacket = true;
            

        }

        else if (collision.tag == "Packet" && hasPacket)
        {
            GameAudio.instance.PlayPackageWarning();
            
        }

        else if(collision.tag == "DeliveryPoint" && hasPacket)
        {
            GameAudio.instance.PlayPackageDelivered();
            DecreasePacketNumber();
            hasPacket = false;
        }

        else if(collision.tag == "Fool")
        {
            GameAudio.instance.PlayFool();
            Destroy(collision.gameObject);
        }
    }

    private void DecreasePacketNumber() => noOfPackeges--;


}
