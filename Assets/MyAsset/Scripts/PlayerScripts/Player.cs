using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigid2D;
    [SerializeField]
    private float JumpPower;
    private int JumpCount;

    public bool isFall;
    public bool isDamaged;
    public bool isPotion;

    public bool ItemGet;

    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        isFall = false;
        isDamaged = false;
        if (!TryGetComponent<SpriteRenderer>(out spriteRenderer)) { Debug.Log("sprite is null"); }
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Falling"))
        {
            isFall = true;
        }

        if (other.gameObject.layer == 3) 
        {
            StartCoroutine("Damage");
            isDamaged = true;
            
        }

        if(other.CompareTag("Potion"))
        {
            isPotion = true;
        }

        if(other.CompareTag("Item"))
        {
            ItemGet = true;
        }
    }

    private IEnumerator Damage()
    {
       
        spriteRenderer.color = Color.clear;
        yield return new WaitForSeconds(0.3f);
        spriteRenderer.color = Color.white;
        yield return new WaitForSeconds(0.3f);
        spriteRenderer.color = Color.clear;
        yield return new WaitForSeconds(0.3f);
        spriteRenderer.color = Color.white;
       
    }
}
