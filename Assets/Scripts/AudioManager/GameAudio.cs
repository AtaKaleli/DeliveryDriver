using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAudio : MonoBehaviour
{

    public static GameAudio instance;

    [SerializeField] private AudioSource backgroundAudio;
    [SerializeField] private AudioSource SFXAudio;

    [SerializeField] private AudioClip packageTaken;
    [SerializeField] private AudioClip packageDelivered;
    [SerializeField] private AudioClip packageWarning;
    [SerializeField] private AudioClip fool;
    


    private void Awake()
    {
        instance = this;
    }



    public void PlayPackageTaken() => SFXAudio.PlayOneShot(packageTaken);
    public void PlayPackageDelivered() => SFXAudio.PlayOneShot(packageDelivered);
    public void PlayPackageWarning() => SFXAudio.PlayOneShot(packageWarning);
    public void PlayFool() => SFXAudio.PlayOneShot(fool);
    



}
