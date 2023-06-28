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
    // Start is called before the first frame update
    void Start()
    {
        isFall = false;
        isDamaged = false;
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
            isDamaged = true;
        }
    }
}
