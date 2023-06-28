using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private float MonsterSpeed;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private SpriteRenderer ChildRender;
    void Start()
    {
        if(!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("Monster.Sprite is null"); }
        if(!TryGetComponent<Animator>(out animator)) { Debug.Log("Monster.Animator is null"); }
    }

    void Update()
    {
        transform.Translate(MonsterSpeed * Time.deltaTime, 0, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            MonsterSpeed = 0;
            animator.SetTrigger("Dead");
            spriteRenderer.enabled = false;
            ChildRender.enabled = false;
            Destroy(gameObject, 2f);
        }
    }
}
