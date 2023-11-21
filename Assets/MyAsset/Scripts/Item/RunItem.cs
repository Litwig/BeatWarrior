using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunItem : MonoBehaviour
{
    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    [SerializeField]
    private GameObject twinkleEffect;

    [SerializeField]
    private GameObject potionEffect;

    public bool isStartRun;
   
    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<CircleCollider2D>(out circleCollider2D)) { Debug.Log("circle null"); }
        if(!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("sprite null"); }
        if(!TryGetComponent<AudioSource>(out audioSource)){ Debug.Log("audio null"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isStartRun = true;
            spriteRenderer.enabled = false;
            potionEffect.SetActive(false);
            Instantiate(twinkleEffect, transform.position, transform.rotation);
            audioSource.Play();
        }
    }
}
