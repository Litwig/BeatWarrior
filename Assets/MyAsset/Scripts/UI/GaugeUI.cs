using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class GaugeUI : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    [SerializeField]
    private ReSpawn reSpawnScript;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < GaugeArray.Length; i++)
        {
            if (i == CharacterData.instance.PlayerIndex)
                GaugeArray[i].SetActive(true);

            else
                GaugeArray[i].SetActive(false);
        }
    }
}
