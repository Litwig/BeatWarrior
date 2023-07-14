using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkillInfoUI : MonoBehaviour
{
    [SerializeField]
    private SkillInfo skillInfoScript;

    public void ButtonSkill1()
    {
        skillInfoScript.type = SkillInfo.SKILL_TYPE.SKILL1;
    }

    public void ButtonSkill2()
    {
        skillInfoScript.type = SkillInfo.SKILL_TYPE.SKILL2;
    }

    public void ButtonSkill3()
    {
        skillInfoScript.type = SkillInfo.SKILL_TYPE.SKILL3;
    }
}
