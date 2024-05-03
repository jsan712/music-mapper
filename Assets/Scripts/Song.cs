using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float _previewStart;

    private float _previewDuration = 30.0f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void RecievePreview(bool isSelected)
    {
        if (isSelected)
        {
            StartCoroutine("PreviewSong");            
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
            yield return new WaitForSeconds(_previewDuration);            
            audioSource.Stop();
            _completed = true;
        }
    }
}
