using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public AudioMixerGroup music;
    public Slider musicslider, audioslider;
    //public GameObject musictoggle;
    //[HideInInspector] public bool ison;


    private void Start()
    {
        //ison = musictoggle.GetComponent<Toggle>().isOn;
    }
    public void ChangeMusic(float volume)
    {
        music.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, volume));
    }
    public void ChangeFX(float volume)
    {
        music.audioMixer.SetFloat("AudioVolume", Mathf.Lerp(-80, 0, volume));
    }
    public void MusicMute(bool tog)
    {
        if (tog == true)
        {
            Debug.Log(tog);
            musicslider.GetComponent<Slider>().enabled = true;
            music.audioMixer.SetFloat("MusicVolume", 0);
        }
        else if(tog == false)
        {
            Debug.Log(tog);
            musicslider.GetComponent<Slider>().enabled = false;
            music.audioMixer.SetFloat("MusicVolume", -80);
        }
    }
    public void FXMute(bool togg)
    {
        if (togg == true)
        {
            Debug.Log(togg);
            audioslider.GetComponent<Slider>().enabled = true;
            music.audioMixer.SetFloat("AudioVolume", 0);
        }
        else if (togg == false)
        {
            Debug.Log(togg);
            audioslider.GetComponent<Slider>().enabled = false;
            music.audioMixer.SetFloat("AudioVolume", -80);
        }
    }
}
