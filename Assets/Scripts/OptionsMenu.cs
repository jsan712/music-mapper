using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

// This code was adapted from Brackey's YouTube video titled "SETTINGS MENU in Unity".
public class OptionsMenu : MonoBehaviour
{
    //public AudioMixer audioMixer;
    private AudioSource audioSource;

    private bool pause = false;
    [SerializeField] private bool loop;
    [SerializeField] private bool autoPlay;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SetVolume (float volume)
    {
        //audioMixer.SetFloat("volume", volume);
        audioSource.volume = volume;
    }

    public void PlayPause(bool pause)
    {
        if (pause == false)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }
    }

    public void Loop(bool loop)
    {
        if (loop)
        {
            audioSource.loop = true;
        }
        else
        {
            audioSource.loop = false;
        }
    }

    public void AutoPlay (bool autoPlay)
    {
        if (autoPlay)
        {
            audioSource.Play();
        }
    }
}
