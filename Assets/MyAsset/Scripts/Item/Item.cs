using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isGetPotion;

    private Animator animator;
    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;

    [SerializeField]
    private float MoveSpeed;
    [SerializeField]
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent<Animator>(out animator)) { Debug.Log("null animator"); }
        if(!TryGetComponent<CircleCollider2D>(out circleCollider2D)) { Debug.Log("null circle"); }
        if(!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("Sprite null"); }
    }

    // Update is called once per frame
    void Update()
    {
        MoveItem();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(this.CompareTag("BlueItem"))
            {
                gameManager.PlayerScore += 300;
            }
            else if(this.CompareTag("PinkItem"))
            {
                gameManager.PlayerScore += 100;
            }
            animator.SetBool("isCollect", true);
            MoveSpeed = 0;
            circleCollider2D.enabled = false;
            spriteRenderer.enabled = false;
            Destroy(gameObject,3f);
        }
    }

    private void MoveItem()
    {
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
    }
}
