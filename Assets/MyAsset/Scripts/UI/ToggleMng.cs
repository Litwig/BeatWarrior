using UnityEngine;
using UnityEngine.UI;

public class ToggleMng : MonoBehaviour
{
    [SerializeField]
    private Toggle[] toggleArray = new Toggle[3];

    private Button toggleButton;

    public int toggleIndex;
    void Start()
    {
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
                toggleIndex = i;
            }
        }

    }
}