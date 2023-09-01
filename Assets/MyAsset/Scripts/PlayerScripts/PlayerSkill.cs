using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField]
    private SkillType skillTypeScript;

    public FinalSkillGauge finalSkillGaugeScript;

    // Start is called before the first frame update
    private void Start()
    {
        if (!finalSkillGaugeScript)
            Debug.Log("null");
    }

    // Update is called once per frame
    private void Update()
    {
        SkillKeySet();
    }

    public void SkillKeySet()
    {
        //Left = Fireball
        //Right = Water
        //Up = Earth

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //1Skill
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.SHOOT_TYPE;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) //3Skill
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.STOP_TYPE;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) //Skill2
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FRONT_TYPE;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!finalSkillGaugeScript.isShoot)
            {
                skillTypeScript.Generate = true;
                skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FINAL_TYPE;
                finalSkillGaugeScript.isShoot = true;
            }
        }
    }
}