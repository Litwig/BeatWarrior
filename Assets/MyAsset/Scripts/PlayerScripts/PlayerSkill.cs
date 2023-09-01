using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{

    [SerializeField]
    private SkillType skillTypeScript;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        SkillKeySet();

    }

    public void SkillKeySet()
    {
        //Left = Fireball
        //Right = Waterball
        //Up = Earth

        if (Input.GetKeyDown(KeyCode.LeftArrow)) //1Skill
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.SHOOT_TYPE;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) //3Skill
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.STOP_TYPE;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)) //Skill2
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FRONT_TYPE;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            skillTypeScript.Generate = true;
            skillTypeScript.enumSkillType = SkillType.SKILLTYPE.FINAL_TYPE;
        }

       

    }
}
