using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class FadeInOut : MonoBehaviour
{
    private Image image;

    public bool isFade;
    // Start is called before the first frame update
    void Start()
    {
        if(!TryGetComponent(out image)) { Debug.Log("Image null"); }
    }

    // Update is called once per frame
    void Update()
    {
        ImageSetting();
    }

    private void ImageSetting()
    {
        if(isFade) //점점 투명해질때
        {
            
        }
        else //점점 까매질때
        {
            for(int i=0; i>1; ++i)
            {
                image.color = new Color(0, 0, 0, i);
            }
        }
    }

    private IEnumerator FadeOut()
    {
        yield return null;
    }    
}
