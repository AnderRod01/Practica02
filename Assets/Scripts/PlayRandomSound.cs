using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] musicList;
    private AudioClip song;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            int index = Random.Range(0, musicList.Length);
            song = musicList[index];

            audioSource.clip = song;
            audioSource.Play();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (audioSource.isPlaying){
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            audioSource.Stop();
        }
    }
}
