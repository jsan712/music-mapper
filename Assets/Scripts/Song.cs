using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private float _previewStart;

    private float _previewDuration = 30.0f;
    private ARTemplateMenuManager _arMenuManger;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        ARTemplateMenuManager potential_ARMenuManager = GameObject.Find("UI").GetComponent<ARTemplateMenuManager>();

        if (potential_ARMenuManager != null)
        {
            _arMenuManger = potential_ARMenuManager;
        }
        else
        {
            _arMenuManger = null;
        }
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
