using System.Collections;
using UnityEngine;

public class FinalSkillGauge : MonoBehaviour
{
    [SerializeField]
    private GameObject[] GaugeArray;

    public float GaugeIndex;

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
            GaugeArray[GaugeArray.Length-1].SetActive(false);

            Invoke("GaugeZero", 1f);
            
            Debug.Log("GaugeIndex:" + GaugeIndex);
            GaugeZero();
            //StartCoroutine(nameof(GaugeCoolTime));
        }

        else
        {
            ChargeGauge();
        }
    }

    private void GaugeZero()
    {
        GaugeIndex -= Time.deltaTime;
        GaugeArray[(int)GaugeIndex].SetActive(false);

        if (GaugeIndex <= 0)
        {
            GaugeIndex = 0;
            isShoot = true;
        }
    }

    private void ChargeGauge()
    {
        if ((int)GaugeIndex >= 0 && (int)GaugeIndex < GaugeArray.Length)  
        {
            GaugeIndex += Time.deltaTime;
            GaugeArray[(int)GaugeIndex].SetActive(true);
        }

        if ((int)GaugeIndex >= GaugeArray.Length - 1) 
        {
            isShoot = false;
            GaugeIndex = GaugeArray.Length - 1;
        }

        //GaugeIndex = Mathf.Max(GaugeArray.Length - 1, 0);
        //GaugeIndex = ((int)gameManager.GetScore / 1000);

        else
        {
            GaugeIndex = GaugeArray.Length - 1;
        }
       
    }


    //private IEnumerator GaugeCoolTime()
    //{
    //   // Debug.Log("内风凭角青傈");
    //    //GaugeIndex = Mathf.Max(GaugeArray.Length - 1, 0);


    //    for(int i=GaugeArray.Length; i<0; --i)
    //    {
         
    //    }

    //    if (GaugeIndex <= 0)
    //    {
    //        GaugeIndex = 0;
    //        isShoot = true;
    //    }
       
    //   // Debug.Log("内风凭角青");
    //}
}