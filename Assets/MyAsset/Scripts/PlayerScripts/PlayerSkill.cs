using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    [SerializeField]
    private SkillType skillTypeScript;

    [SerializeField]
    private GameManager GameManagerScript;

    [SerializeField]
    private FinalSkillGauge[] GaugeScriptArray;

    private int index;

    
    // Start is called before the first frame update
    private void Start()
    {
        GameManagerScript = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        for (int i = 0; i < GaugeScriptArray.Length; ++i)
        {
            GaugeScriptArray[i] = GameManagerScript.GaugeArray[i].GetComponent<FinalSkillGauge>();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        index = GameManagerScript.GaugeIndex;
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
            if (!GaugeScriptArray[index].isShoot)
            {
                skillTypeScript.Generate = true;
                skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FINAL_TYPE;
                GaugeScriptArray[index].isShoot = true;

            }
        }
    }
}