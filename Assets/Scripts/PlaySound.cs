using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    private AudioSource note;
    public AudioClip noteSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        note = GetComponent<AudioSource>();
        note.PlayOneShot(noteSound, 1.0f);
    }
}
