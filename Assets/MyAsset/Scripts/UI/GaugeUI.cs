using UnityEngine;

public class GaugeUI : MonoBehaviour
{
    public GameObject[] GaugeArray;

    [SerializeField]
    private ReSpawn reSpawnScript;

    public int GaugeUI_Index;

    public bool isGaugeLess;
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
        if (!isGaugeLess)
        {
            GaugeArray[GaugeUI_Index].SetActive(true);
        }
        else
        {
            GaugeArray[GaugeUI_Index].SetActive(false);
        }
    }
}