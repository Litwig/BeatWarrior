using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FinalSkillGauge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    [SerializeField]
    private int GaugeIndex;

    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    public bool isShoot;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i=0; i<GaugeArray.Length; i++)
        {
            GaugeArray[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isShoot)
        {
            GaugeZero();
        }
        else
        {
            ChargeGauge();
        }
    }

    private void ChargeGauge()
    {
        if (GaugeIndex != GaugeArray.Length - 1)
        {
            GaugeIndex = ((int)gameManager.GetScore / 1000);
        }
        else
        {
            GaugeIndex = GaugeArray.Length - 1;
        }

        GaugeArray[GaugeIndex].SetActive(true);
    }

    private void GaugeZero()
    {
        if (GaugeIndex == GaugeArray.Length - 1)
        {
            StartCoroutine("GaugeCoolTime");
        }
        else if(GaugeIndex<=0)
        {
            GaugeIndex = 0;
        }
    }

    IEnumerator GaugeCoolTime()
    {
        GaugeIndex--;
        GaugeArray[GaugeIndex].SetActive(false);
        yield return new WaitForSeconds(1f);
    }

}
