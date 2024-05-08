using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using static Unity.VisualScripting.Member;

public class ActivateNode : MonoBehaviour
{
    [SerializeField] public NodeCode node;
    [SerializeField] public int song;

    private ARTemplateMenuManager spawner;

    void Start()
    {
        spawner = GameObject.Find("UI").GetComponent<ARTemplateMenuManager>();
    }

    public void CreateNode()
    {
        node.index = song;
        spawner.SetObjectToSpawn(1);
        Debug.Log("Now playing song " + song);
    }

    public void NoNode()
    {
        spawner.SetObjectToSpawn(0);
    }
}
