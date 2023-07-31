using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvent : MonoBehaviour
{
    [SerializeField]
    PlayerSkill playerSkillScript;
    public void OnEventSkill()
    {
       // playerSkillScript.isShoot = true;
    }
}
