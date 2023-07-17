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
    private TMP_Text[] SkillText;
    [SerializeField]
    private TMP_Text[] SkillNameText;
    [SerializeField]
    private CharacterData characterData_Script;

    [SerializeField]
    private TMP_Text PlayerName;
    private void Start()
    {
        InfoPanel.SetActive(false);
        for (int i = 0; i < SkillText.Length; i++)
        {
            SkillNameText[i].text = characterData_Script.PlayerSkillName[i];
            SkillText[i].text = characterData_Script.PlayerSkill[i];
        }
    }

    private void Update()
    {
      
    }
    public void DarkMageInfoActive()
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.BLACKMAGE;
        PlayerName.text = characterData_Script.PlayerName;
        
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

        for (int i=0; i<SkillText.Length; i++)
        {
            SkillNameText[i].text = characterData_Script.PlayerSkillName[i];
            SkillText[i].text = characterData_Script.PlayerSkill[i];            
        }
    }
    
    public void HolyMageInfoActive() 
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.HOLYMAGE;
        PlayerName.text = characterData_Script.PlayerName;

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

        for (int i = 0; i < SkillText.Length; i++)
        {
            SkillNameText[i].text = characterData_Script.PlayerSkillName[i];
            SkillText[i].text = characterData_Script.PlayerSkill[i];
        }
    }  
    
    public void IceMageInfoActive()
    {
        InfoPanel.SetActive(true);
        characterData_Script.playerType = CharacterData.PLAERTYPE.ICEMAGE;
        PlayerName.text = characterData_Script.PlayerName;

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

        for (int i = 0; i < SkillText.Length; i++)
        {
            SkillNameText[i].text = characterData_Script.PlayerSkillName[i];
            SkillText[i].text = characterData_Script.PlayerSkill[i];
        }
    }

    public void PanelClose()
    {
        InfoPanel.SetActive(false);
    }
}
