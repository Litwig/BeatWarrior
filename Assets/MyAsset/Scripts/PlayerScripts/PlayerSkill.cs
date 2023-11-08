using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField]
    private SkillType skillTypeScript;

    
    public FinalSkillGauge[] GaugeScriptArray;

    public FinalSkillGauge finalSkillGaugeScript;

    private int index;

    public bool isIndexFull;
    
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        index = CharacterData.instance.PlayerIndex;
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
            if (finalSkillGaugeScript.GaugeIndex == finalSkillGaugeScript.GaugeArrayFullIndex && !isIndexFull) 
            {
                skillTypeScript.Generate = true;
                skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FINAL_TYPE;
                GaugeScriptArray[index].isShoot = true;
            }

            else
            {
                return;
            }
        }
    }
}