using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerSkill : MonoBehaviour
{
    #region SKILL_PREFAB
    [SerializeField]
    private GameObject FireBallPrefab;
    [SerializeField]
    private GameObject WaterPrefab;
    [SerializeField]
    private GameObject EarthPrefab;
    #endregion

    private GameObject SkillObj;
    public bool isShoot;

    [SerializeField]
    private Transform SKillTrasform;
    
    // Start is called before the first frame update
    void Start()
    {
        isShoot = false;
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

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SkillObj = Instantiate(FireBallPrefab, SKillTrasform.position, SKillTrasform.rotation);

        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            SkillObj = Instantiate(WaterPrefab, SKillTrasform.position, SKillTrasform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SkillObj = Instantiate(EarthPrefab, SKillTrasform.position, SKillTrasform.rotation);
        }

       

    }
}
