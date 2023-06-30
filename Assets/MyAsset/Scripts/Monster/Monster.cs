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
    private BoxCollider2D boxCollider;

    public bool MonsterDead;

    void Start()
    {
        if(!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("Monster.Sprite is null"); }
        if(!TryGetComponent<Animator>(out animator)) { Debug.Log("Monster.Animator is null"); }
        if(!TryGetComponent<BoxCollider2D>(out boxCollider)) { Debug.Log("Monster Collider is null"); }
    }

    void Update()
    {
        transform.Translate(MonsterSpeed * Time.deltaTime, 0, 0);
        MonsterDestroy();
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

        if(other.CompareTag("Fire"))
        {
            if(this.gameObject.CompareTag("RedMonster"))
            {
                MonsterDead = true;
            }
        }

        if(other.CompareTag("Water"))
        {
            if (this.gameObject.CompareTag("BlueMonster"))
            {
                MonsterDead = true;
            }
        }

        if(other.CompareTag("Earth"))
        {
            if (this.gameObject.CompareTag("GreenMonster"))
            {
                MonsterDead = true;
            }
        }
    }

    private void MonsterDestroy()
    {
        if(MonsterDead==true)
        {
            animator.SetBool("Dead", true);
            MonsterSpeed = 0;
            boxCollider.enabled = false;
            Destroy(gameObject, 3f);
        }
        
    }
}
