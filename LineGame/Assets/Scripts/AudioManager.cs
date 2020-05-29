using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioClip ClickSound;
    public static AudioSource audioSrc;
   


    void Start()
    {
       
        ClickSound = Resources.Load<AudioClip>("ClickButton");
        audioSrc = GetComponent<AudioSource>();
    }





   public static  void playSound(string Clip)
    {
       if(Clip =="ClickButton")
        {
            audioSrc.PlayOneShot(ClickSound);
        }
        
    }
}
