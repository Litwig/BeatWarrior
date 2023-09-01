using System.Collections;
using UnityEngine;

public class FinalSkillGauge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    private int GaugeIndex;

    [SerializeField]
    private GameManager gameManager;

    public bool isShoot;

    // Start is called before the first frame update
    private void Start()
    {
        GaugeIndex = (int)gameManager.GetScore / 1000;
        for (int i = 0; i < GaugeArray.Length; i++)
        {
            GaugeArray[i].SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (isShoot)
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
        else if (GaugeIndex <= 0)
        {
            GaugeIndex = 0;
        }
    }

    private IEnumerator GaugeCoolTime()
    {
        GaugeIndex--;
        GaugeArray[GaugeIndex].SetActive(false);
        yield return new WaitForSeconds(1f);
    }
}