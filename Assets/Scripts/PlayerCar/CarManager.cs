using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{

    [SerializeField] private SpriteRenderer packageSprite;

    private bool hasPacket;
    public int noOfPackeges = 7;

    private void Awake()
    {
        packageSprite.enabled = false;
    }

    private void Update()
    {
        GameUI.instance.ShowRemainingPackeges(noOfPackeges);
        if(noOfPackeges == 0)
            GameUI.instance.GameOverInformation("Well Done!\n\n You have delivered every package successfully!");
        
        
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
            GameUI.instance.GameOverInformation("You crashed!\n\nYou could not have delivered packages on time!");

        }
    }

    private void DecreasePacketNumber() => noOfPackeges--;


}
