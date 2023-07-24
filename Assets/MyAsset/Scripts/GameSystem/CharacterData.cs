using UnityEngine;


public class CharacterData : MonoBehaviour
{
    public static CharacterData instance;

    private enum PLAYERTYPE { BLACKMAGE, HOLYMAGE, ICEMAGE, MAGE_COUNT }
    private PLAYERTYPE playerType;

    public int PlayerIndex;

    private void Awake()
    {
       if (instance == null)
       {
           instance = this;
           DontDestroyOnLoad(this.gameObject);
       }

       else
       {
           Destroy(this.gameObject);
       }
    }

    public void SelectCharacterIndex(int index)
    {
        PlayerIndex = index;
    }


}
