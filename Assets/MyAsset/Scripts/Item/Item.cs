using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isGetPotion;

    private Animator animator;
    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;

    private GameManager gameManager;

    private AudioSource audioSource;
    private AudioClip clip;

    // Start is called before the first frame update
    private void Start()
    {
        if (!TryGetComponent<Animator>(out animator)) { Debug.Log("null animator"); }
        if (!TryGetComponent<CircleCollider2D>(out circleCollider2D)) { Debug.Log("null circle"); }
        if (!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("Sprite null"); }
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        if (!TryGetComponent<AudioSource>(out audioSource)) { Debug.Log("null audio"); }
        clip = audioSource.clip;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.CompareTag("BlueItem"))
            {
                gameManager.PlayerScore += 300;
            }
            else if (this.CompareTag("PinkItem"))
            {
                gameManager.PlayerScore += 100;
            }
            animator.SetBool("isCollect", true);

            circleCollider2D.enabled = false;
            audioSource.Play();
            Destroy(gameObject, clip.length);
        }
    }
}