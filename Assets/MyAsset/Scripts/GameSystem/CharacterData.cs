using UnityEngine;
using UnityEngine.UI;

public enum PLAYERTYPE { BLACKMAGE, HOLYMAGE, ICEMAGE, MAGE_COUNT }
public class CharacterData : MonoBehaviour
{
    public static CharacterData instance;
    
    public PLAYERTYPE playerType;

    public ToggleMng toggleMngScript;

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

    private void Update()
    {
        playerType = (PLAYERTYPE)toggleMngScript.toggleIndex;
    }


}
