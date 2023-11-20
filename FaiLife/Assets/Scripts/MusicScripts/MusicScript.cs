using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class Music : MonoBehaviour
{
    [SerializeField] public AudioSource audioLine1;
    [SerializeField] public AudioSource audioLine2;
    [SerializeField] public Slider musicSlider;
    private Transform handleTransform;

    private void Start()
    {
        audioLine1.loop = true;
        audioLine2.loop = true;

        float volume = float.Parse(PlayerPrefs.GetString("MasterVolume", "0.5"));
        audioLine1.volume = volume;
        musicSlider.normalizedValue = volume;
    }

    public void SetMusicVolume()
    {
        float volume1 = musicSlider.value;
        audioLine1.volume = volume1;

        float volume2 = musicSlider.value;
        audioLine2.volume = volume2;
    }

    public void SaveMasterVolumeSettings()
    {
        PlayerPrefs.SetString("MasterVolume", audioLine1.volume.ToString());
    }
}
