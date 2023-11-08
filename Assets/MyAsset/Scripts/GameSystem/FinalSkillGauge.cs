using System.Collections;
using UnityEngine;

public class FinalSkillGauge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    public float GaugeIndex;
    public int GaugeArrayFullIndex;

    public bool isShoot;
    private int GaugeIndex_int => (int)GaugeIndex;

    // Start is called before the first frame update
    private void Start()
    {
        GaugeArrayFullIndex = GaugeArray.Length - 1;
    }

    // Update is called once per frame
    private void Update()
    {
        GaugeChange();
    }

    private void GaugeChange()
    {
        if(isShoot) //±Ã½úÀ»¶§
        {
            GaugeIndex -= Time.deltaTime;

            if (GaugeIndex <= 0)
            {
                GaugeIndex = 0;
                isShoot = true;
            }
        }

        else //±Ã¾øÀ»¶§
        {

            if (GaugeIndex_int >= 0 && GaugeIndex_int < GaugeArray.Length)
            {
                GaugeIndex += Time.deltaTime;
            }

            if (GaugeIndex_int >= GaugeArray.Length - 1)
            {
                GaugeIndex = GaugeArray.Length - 1;
            }

        }

    }
}