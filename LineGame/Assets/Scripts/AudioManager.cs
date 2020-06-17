using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip ClickSound;
    public static AudioSource audioSrc;
    public static AudioClip ShotSound;
    public static AudioClip Win;



    void Start()
    {

        ClickSound = Resources.Load<AudioClip>("ClickButton");
        ShotSound = Resources.Load<AudioClip>("shoot");
        Win = Resources.Load<AudioClip>("WinEffect");
        audioSrc = GetComponent<AudioSource>();
    }



    public static void playSound(string Clip)
    {
        switch (Clip)
        {
            case "ClickSound":

                audioSrc.PlayOneShot(ClickSound);
                break;
            case "shoot":

                audioSrc.PlayOneShot(ShotSound);
                break;
            case "WinEffect":

                audioSrc.PlayOneShot(Win);
                break;
        }

    }
}