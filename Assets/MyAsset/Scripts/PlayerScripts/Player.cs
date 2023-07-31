using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigid2D;
    [SerializeField]
    private float JumpPower;
    [SerializeField]
    private int JumpCount;

    public bool isFall;
    public bool isDamaged;
    public bool isPotion;

    public bool ItemGet;

    private bool isNoHitTime;
    private float CurrTime;
    // Start is called before the first frame update
    void Start()
    {
        isFall = false;
        isDamaged = false;
        JumpCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        CurrTime += Time.deltaTime;
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (JumpCount > 0)
            {
                
                rigid2D.AddForce(Vector3.up * JumpPower, ForceMode2D.Impulse);
                --JumpCount;
            }
            else
            { 
            }
        
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

        if(other.CompareTag("Ground"))
        {
            JumpCount = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
     
    }

}
