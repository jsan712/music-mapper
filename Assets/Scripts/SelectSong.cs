using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class SelectSong : MonoBehaviour
{
    public AudioClip[] songs;
    [SerializeField] public AudioSource source;
    private GameObject display_info;
    private ARTemplateMenuManager other_script;

    string text;

    // Start is called before the first frame update
    void Start()
    {
        display_info = GameObject.Find("Music Node Info");
        //display_info.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Start of Update");
        ARTemplateMenuManager potential_other_script = GameObject.Find("UI").GetComponent<ARTemplateMenuManager>();

        if (potential_other_script != null)
        {
            other_script = potential_other_script;
            Debug.Log("ARMenu if");
        }
        else
        {
            other_script = null;
        }

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch.ToString());

            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit Hit;

            Debug.Log("Before Raycast if");

            if (Physics.Raycast(ray, out Hit))
            {
                Debug.Log("Before hit.transform if");
                if (Hit.transform != null)
                {
                    text = Hit.transform.name;

                    Debug.Log("Before switch");
                    switch (text)
                    {
                        case "BonnieClyde":
                            source.clip = songs[0];
                            source.Play();
                            other_script.SetObjectToSpawn(8);
                            Debug.Log("BonnieClyde has been touched.");
                            break;
                        case "PosterBoy":
                            source.clip = songs[1];
                            source.Play();
                            other_script.SetObjectToSpawn(8);
                            Debug.Log("PosterBoy has been touched.");
                            break;
                        case "GlimpseofUs":
                            source.clip = songs[2];
                            source.Play();
                            other_script.SetObjectToSpawn(8);
                            Debug.Log("GlimpseofUs has been touched.");
                            break;
                        default:
                            display_info.SetActive(false);
                            break;
                    }
                }
            }
        }
    }

    // This function is activated when the player selects an album cover from the bookshelf
    public void SongSelected()
    {
        source.clip = songs[0];
        source.Play();
        other_script.SetObjectToSpawn(8);
        Debug.Log(source.clip.ToString() + " has been touched.");
    }
}
