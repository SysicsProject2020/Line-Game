using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource BackGroundAudio;
    public AudioSource ButtonAudio;



    public void setLevel1(float sliderValue)
    {
        mixer.SetFloat("musicVOlume", Mathf.Log10(sliderValue)*20);
    }
    public void setLevel2(float sliderValue)
    {
        mixer.SetFloat("musicVOlume", Mathf.Log10(sliderValue) * 30);
    }

}
