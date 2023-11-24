using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator animator;

    public float UpSpeed;

    public bool isRun;
    //[SerializeField]
    //private GameManager gameManager;

    // Start is called before the first frame update
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerAnimation();
        if(isRun)
        {
            PlayerRun();
        }
        else
        {
            //animator original speed
            animator.speed = 1;
        }
    }

    private void PlayerAnimation()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Trigger_Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetTrigger("Trigger_Attack");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Trigger_Skill");
        }

        //if(gameManager.isDead==true)
        //{
        //    animator.SetBool("isDead", true);
        //}
    }

    private void PlayerRun()
    {
        animator.speed = UpSpeed;
    }
}