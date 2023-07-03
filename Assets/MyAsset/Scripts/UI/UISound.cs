using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISound : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<AudioSource>(out audioSource)) { Debug.Log(""); }
    }

    public void Sound_Play()
    {
        audioSource.Play();
    }    
}
