using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private float MonsterSpeed;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private SpriteRenderer ChildRender;

    private BoxCollider2D boxCollider;

    public bool MonsterDead;

    private AudioSource audioSource;
    private AudioClip clip;

    private void Start()
    {
        if (!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("Monster.Sprite is null"); }
        if (!TryGetComponent<Animator>(out animator)) { Debug.Log("Monster.Animator is null"); }
        if (!TryGetComponent<BoxCollider2D>(out boxCollider)) { Debug.Log("Monster Collider is null"); }
        if (!TryGetComponent<AudioSource>(out audioSource)) { Debug.Log("Monster Audio is null"); }
        clip = audioSource.clip;
    }

    private void Update()
    {
        transform.Translate(MonsterSpeed * Time.deltaTime, 0, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            MonsterSpeed = 0;
            animator.SetTrigger("Dead");
            boxCollider.enabled = false;
            Destroy(gameObject, 0.5f);
        }

        if (other.CompareTag("Skill"))
        {
            MonsterSpeed = 0;
            animator.SetTrigger("Dead");
            boxCollider.enabled = false;
            audioSource.Play();
            Destroy(gameObject, clip.length);
        }
    }
}