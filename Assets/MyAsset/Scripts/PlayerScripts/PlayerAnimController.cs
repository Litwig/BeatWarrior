using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //animator.TryGetComponent<Animator>(out animator);

        //if (animator == null)
        //    Debug.Log("null");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAnimation();
    }

    private void PlayerAnimation()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Trigger_Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            animator.SetTrigger("Trigger_Attack");
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("Trigger_Skill");
        }
    }
}
