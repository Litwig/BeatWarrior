using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip JumpClip;
    [SerializeField]
    private AudioClip HitClip;
    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<AudioSource>(out audioSource)) { Debug.Log("audio"); }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.clip = JumpClip;
            audioSource.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer ==3)
        {
            audioSource.clip = HitClip;
            audioSource.Play();
        }
    }
}
