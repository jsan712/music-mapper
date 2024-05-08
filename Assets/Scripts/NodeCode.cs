using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class NodeCode : MonoBehaviour
{
    public AudioClip[] songs;
    private AudioSource source;
    public int index;
    public GameObject nodeOptionsButton;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = songs[index];
        source.Play();

        nodeOptionsButton = GameObject.FindGameObjectWithTag("Options");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMenuButton()
    {
        nodeOptionsButton.SetActive(true);
    }

    public void hideMenuButton()
    {
        nodeOptionsButton.SetActive(false);
    }
}
