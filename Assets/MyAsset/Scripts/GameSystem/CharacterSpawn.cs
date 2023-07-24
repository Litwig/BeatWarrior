using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour
{
    //캐릭터 스폰해줌
    public enum PLAERTYPE { BLACKMAGE, HOLYMAGE, ICEMAGE, MAGE_COUNT }
    public PLAERTYPE playerType = PLAERTYPE.MAGE_COUNT;

    [SerializeField]
    private GameObject[] CharacterArray;
    public GameObject CharacterPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterLoad();
    }

    private void CharacterLoad()
    {
        switch (playerType)
        {
            case PLAERTYPE.BLACKMAGE:
                CharacterPrefab = CharacterArray[0];
                break;

            case PLAERTYPE.HOLYMAGE:
                CharacterPrefab = CharacterArray[1];
                break;

            case PLAERTYPE.ICEMAGE:
                CharacterPrefab = CharacterArray[2];
                break;
        }
    }
}
