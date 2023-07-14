using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] button;

    [SerializeField]
    private Toggle[] toggle;

    private void Start()
    {
      
    }

    private void Update()
    {
        PressKey();
    }

    public void PressKey()
    {
        for(int i=0; i<toggle.Length; i++)
        {
            if (toggle[i].isOn)
            {
                button[i].SetActive(true);
            }
            else
            {
                button[i].SetActive(false);
            }
        }
       
    }
}
