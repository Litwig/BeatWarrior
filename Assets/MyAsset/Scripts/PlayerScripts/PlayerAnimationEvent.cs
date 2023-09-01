using UnityEngine;

public class PlayerAnimationEvent : MonoBehaviour
{
    [SerializeField]
    private PlayerSkill playerSkillScript;

    public void OnEventSkill()
    {
        // playerSkillScript.isShoot = true;
    }
}