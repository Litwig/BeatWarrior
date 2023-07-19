using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfoUI : MonoBehaviour
{
    [SerializeField]
    private GameObject InfoPanel;

    [SerializeField]
    private GameObject[] Character;
    [SerializeField]
    private CharacterData characterData_Script;
    private void Start()
    {
        InfoPanel.SetActive(false);
    }

    private void Update()
    {
      
    }
    public void DarkMageInfoActive()
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.BLACKMAGE;

        for(int i=0; i<3; i++)
        {
            if(i==0)
            {
                Character[i].SetActive(true);
            }

            else
            {
                Character[i].SetActive(false);
            }
        }
    }
    
    public void HolyMageInfoActive() 
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.HOLYMAGE;

        for (int i = 0; i < 3; i++)
        {
            if (i == 1)
            {
                Character[i].SetActive(true);
            }

            else
            {
                Character[i].SetActive(false);
            }
        }
    }  
    
    public void IceMageInfoActive()
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.ICEMAGE;

        for (int i = 0; i < 3; i++)
        {
            if (i == 2)
            {
                Character[i].SetActive(true);
            }
            else
            {
                Character[i].SetActive(false);
            }
        }
    }

    public void PanelClose()
    {
        InfoPanel.SetActive(false);
    }
}
