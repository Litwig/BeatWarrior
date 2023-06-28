using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    Button button;
    Image image;
    private void Start()
    {
        if(!TryGetComponent<Button>(out button)) { Debug.Log("Button is null"); }
        if (!TryGetComponent<Image>(out image)) { Debug.Log("Image is null"); }
    }

    private void Update()
    {
        
    }

    public void PressKey()
    {
        
       
    }
}
