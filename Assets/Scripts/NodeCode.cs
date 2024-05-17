using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class NodeCode : MonoBehaviour
{
    public AudioClip[] songs;
    private AudioSource source;
    public int index;

    private bool isClicked = false;

    [SerializeField] private GameObject nodeOptionsButton;
    [SerializeField] private GameObject nodeOptionsMenu;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = songs[index];
        source.Play();

        nodeOptionsButton.SetActive(false);
        nodeOptionsMenu.SetActive(false);
    }

    public void showHideMenu()
    {
        if (!isClicked)
        {
            nodeOptionsMenu.SetActive(true);
            isClicked = true;
        }
        else
        {
            nodeOptionsMenu.SetActive(false);
            isClicked = false;
        }
    }
}
