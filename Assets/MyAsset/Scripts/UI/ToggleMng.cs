using UnityEngine;
using UnityEngine.UI;

public class ToggleMng : MonoBehaviour
{
    [SerializeField]
    private Toggle[] toggleArray = new Toggle[3];

    private Button toggleButton;

    [SerializeField]
    private CharacterData characterData;

    void Start()
    {
        characterData = GameObject.FindWithTag("GameSystem").GetComponent<CharacterData>();
        for(int i = 0; i < toggleArray.Length; i++)
        {
            toggleButton = toggleArray[i].transform.GetComponentInChildren<Button>();
        }

    }


    void Update()
    {
        ToggleSelect();
    }

    private void ToggleSelect()
    {
        for(int i = 0; i < toggleArray.Length; i++)
        {
            toggleButton.gameObject.SetActive(toggleArray[i].isOn);
            if (toggleArray[i].isOn)
            {
                characterData.SelectCharacterIndex(i);
            }
        }

    }
}