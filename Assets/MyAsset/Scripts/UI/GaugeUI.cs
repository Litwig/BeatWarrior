using UnityEngine;

public class GaugeUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    [SerializeField]
    private ReSpawn reSpawnScript;

    private bool isGaugeFull;
    
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < GaugeArray.Length; i++)
        {
            GaugeArray[i].SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if(!isGaugeFull)
        {
            for (int i = 0; i < GaugeArray.Length; i++)
            {
                if (i == CharacterData.instance.PlayerIndex)
                {
                    GaugeArray[i].SetActive(true);
                    if (i == GaugeArray.Length)
                        isGaugeFull = true;
                }

                else
                    GaugeArray[i].SetActive(false);
            }
        }
        
        if(isGaugeFull)
        {
            for (int i = GaugeArray.Length; i >= 0; i--)
            {
                if (i == CharacterData.instance.PlayerIndex)
                {
                    GaugeArray[i].SetActive(false);

                    if (i <= 0)
                        isGaugeFull = false;
                }
            }
        }        
    }
}