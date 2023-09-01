using System.Collections.Generic;
using UnityEngine;

public class SelectGrey : MonoBehaviour
{
    public enum COLORTYPE
    { SELECT_TYPE, STAGE_TYPE }

    public COLORTYPE ColorType;

    [SerializeField]
    private SPUM_SpriteList spriteList;

    private List<SpriteRenderer> Spum_itemList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_eyeList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_hairList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_bodyList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_clothList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_armorList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_pantList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_weaponList = new List<SpriteRenderer>();
    private List<SpriteRenderer> Spum_backList = new List<SpriteRenderer>();

    public bool isSelect;

    // Start is called before the first frame update
    private void Start()
    {
        Spum_itemList = spriteList._itemList;
        Spum_eyeList = spriteList._eyeList;
        Spum_hairList = spriteList._hairList;
        Spum_bodyList = spriteList._bodyList;
        Spum_clothList = spriteList._clothList;
        Spum_armorList = spriteList._armorList;
        Spum_pantList = spriteList._pantList;
        Spum_weaponList = spriteList._weaponList;
        Spum_backList = spriteList._backList;
    }

    // Update is called once per frame
    private void Update()
    {
        switch (ColorType)
        {
            case COLORTYPE.SELECT_TYPE:
                if (isSelect)
                {
                    SpriteColor(Color.white);
                }
                else
                {
                    SpriteColor(Color.grey);
                }
                break;

            case COLORTYPE.STAGE_TYPE:
                break;
        }
    }

    public void SpriteColor(Color color)
    {
        for (int i = 0; i < Spum_itemList.Count; i++)
        {
            Spum_itemList[i].color = color;
        }

        for (int i = 0; i < Spum_eyeList.Count; i++)
        {
            Spum_eyeList[i].color = color;
        }

        for (int i = 0; i < Spum_hairList.Count; i++)
        {
            Spum_hairList[i].color = color;
        }

        for (int i = 0; i < Spum_bodyList.Count; i++)
        {
            Spum_bodyList[i].color = color;
        }

        for (int i = 0; i < Spum_clothList.Count; i++)
        {
            Spum_clothList[i].color = color;
        }

        for (int i = 0; i < Spum_armorList.Count; i++)
        {
            Spum_armorList[i].color = color;
        }

        for (int i = 0; i < Spum_pantList.Count; i++)
        {
            Spum_pantList[i].color = color;
        }

        for (int i = 0; i < Spum_weaponList.Count; i++)
        {
            Spum_weaponList[i].color = color;
        }

        for (int i = 0; i < Spum_backList.Count; i++)
        {
            Spum_backList[i].color = color;
        }
    }
}