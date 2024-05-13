using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float _previewStart;
    [SerializeField] private GameObject songInformation;

    private float _previewDuration = 30.0f;
    private int numTouch;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        songInformation.SetActive(false);
        numTouch = 0;
    }

    public void RecievePreview()
    {
        numTouch++;
        if (numTouch % 2 == 1)
        {
            Debug.Log(numTouch.ToString());
            StartCoroutine("PreviewSong");            
        }
        else if (numTouch % 2 == 0)
        {
            numTouch = 0;
            songInformation.SetActive(false);
            StopCoroutine("PreviewSong");
            Debug.Log(numTouch.ToString());
        }
    }

    IEnumerator PreviewSong()
    {
        Debug.Log("PreviewSong Coroutine");
        bool _completed = false;

        while (_completed == false)
        {
            audioSource.time = _previewStart;
            audioSource.Play();
            songInformation.SetActive(true);
            yield return new WaitForSeconds(_previewDuration);            
            audioSource.Stop();
            songInformation.SetActive(false);
            _completed = true;
        }
    }

    public void ResetNumTouches()
    {
        numTouch = 0;
        Debug.Log("reset");
    }
}
