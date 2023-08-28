using Unity.VisualScripting;
using UnityEngine;

public class SkillType : MonoBehaviour
{
    public enum SKILLTYPE { SHOOT_TYPE, FRONT_TYPE, STOP_TYPE, FINAL_TYPE ,END_TYPE }

    public SKILLTYPE enumSkillType;

    [SerializeField]
    private float SkillSpeed;
    [SerializeField]
    private GameObject[] SkillArray;
    [SerializeField]
    private GameObject ShootSkillObj;
    [SerializeField]
    private GameObject StopSkillObj;

    public bool Generate;
    [SerializeField]
    private Transform[] SkillPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Generate)
        {
            TypeSelect();
        }

    }

    private void TypeSelect()
    {
        switch (enumSkillType)
        {
            case SKILLTYPE.SHOOT_TYPE:
                Instantiate(ShootSkillObj, SkillPos[0].position, SkillPos[0].rotation);
                Generate = false;
                break;
            case SKILLTYPE.FRONT_TYPE:
                GameObject[] SkillArrayPrefab = new GameObject[3];

                for(int i= 0; i < SkillArrayPrefab.Length; ++i)
                {
                    SkillArrayPrefab[i] = SkillArray[i];
                }
                Instantiate(SkillArrayPrefab[0], transform.position, transform.rotation);
                Instantiate(SkillArrayPrefab[1], transform.position + new Vector3(1.5f, 0, 0), transform.rotation);
                Instantiate(SkillArrayPrefab[2], transform.position + new Vector3(3.0f, 0, 0), transform.rotation);
                Generate = false;
                break;
            case SKILLTYPE.STOP_TYPE:
                Instantiate(StopSkillObj, SkillPos[1].position, SkillPos[1].rotation);
                Generate = false;
                break;
            case SKILLTYPE.FINAL_TYPE:

                break;
        }
    }
}
