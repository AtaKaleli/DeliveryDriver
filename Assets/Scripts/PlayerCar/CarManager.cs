using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{

    [SerializeField] private SpriteRenderer packageSprite;

    private bool hasPacket;
    private int noOfPackeges = 7;

    private void Awake()
    {
        packageSprite.enabled = false;
    }

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
            packageSprite.enabled = true;

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
            packageSprite.enabled = false;
        }

        else if(collision.tag == "Fool")
        {
            GameAudio.instance.PlayFool();
            Destroy(collision.gameObject);
        }

        else if(collision.tag == "DangerousCar")
        {
            GameAudio.instance.MuteBackgroundAudio();
            GameAudio.instance.PlayCarCrash();
            
            Time.timeScale = 0; //end the game
        }
    }

    private void DecreasePacketNumber() => noOfPackeges--;


}
