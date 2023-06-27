using System.Collections;
using System.Collections.Generic;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("HitPoint"))
        {
            Destroy(this);
        }
    }


}
