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

    [SerializeField]
    private float SkillSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SkillKeySet()
    {
        //Left = Fireball
        //Right = Waterball
        //Up = Earth
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject FireballObj = Instantiate(FireBallPrefab, transform.position, transform.rotation);
            
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject WaterBall = Instantiate(WaterPrefab, transform.position, transform.rotation);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject EarthObj = Instantiate(EarthPrefab, transform.position, transform.rotation);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("HitPoint"))
        {
            Destroy(this);
        }
    }


}
