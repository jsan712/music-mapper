using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

// This code was adapted from Brackey's YouTube video titled "SETTINGS MENU in Unity".
public class OptionsMenu : MonoBehaviour
{
    private AudioSource audioSource;
    private bool pause = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SetVolume (float volume)
    {
        audioSource.volume = volume;
    }

    public void PlayPause()
    {
        if (!pause)
        {
            audioSource.Pause();
            pause = true;
        }
        else
        {
            audioSource.UnPause();
            pause = false;
        }
    }
}
