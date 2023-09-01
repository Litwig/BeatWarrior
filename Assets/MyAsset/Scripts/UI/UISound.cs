using UnityEngine;

public class UISound : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    private void Start()
    {
        if (!TryGetComponent<AudioSource>(out audioSource)) { Debug.Log(""); }
    }

    public void Sound_Play()
    {
        audioSource.Play();
    }
}