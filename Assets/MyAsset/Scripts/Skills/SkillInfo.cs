using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillInfo : MonoBehaviour
{
    private Animator animator;

    public enum SKILL_TYPE { SKILL_NONE ,SKILL1, SKILL2, SKILL3, SKILL_COUNT };
    public SKILL_TYPE type;
    void Start()
    {
        if(!TryGetComponent(out animator)) { Debug.Log("animator null"); }
    }

    // Update is called once per frame
    void Update()
    {
        SkillPlay();
    }

    private void SkillPlay()
    {
        switch(type)
        {
            case SKILL_TYPE.SKILL1:
                animator.SetTrigger("Skill1");
                break;
            case SKILL_TYPE.SKILL2:
                animator.SetTrigger("Skill2");
                break;
            case SKILL_TYPE.SKILL3:
                animator.SetTrigger("Skill3");
                break;
        }
    }
}
