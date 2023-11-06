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
        GaugeIndex = gameManager.SkillGaugeIndex;
        for (int i = 0; i < GaugeArray.Length; i++)
        {
            GaugeArray[i].SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        GaugeIndex = gameManager.SkillGaugeIndex;
        if (isShoot) //이거 궁 쏘고난뒤
        {
            //GaugeArray[GaugeArray.Length-1].SetActive(false);

            //Invoke("GaugeZero", 1f);
            GaugeZero();
            //StartCoroutine(nameof(GaugeCoolTime));
        }

        else //isShoot = false 아직 궁극기 안쐈을때
        {
            if ((int)GaugeIndex >= 0 && (int)GaugeIndex < GaugeArray.Length) 
            {
                //GaugeIndex += Time.deltaTime;
                GaugeArray[(int)GaugeIndex].SetActive(true);
            }

            if ((int)GaugeIndex == GaugeArray.Length - 1)
            {
                isShoot = false;
                GaugeIndex = GaugeArray.Length;
            }
            //ChargeGauge();
        }
    }

    private void GaugeZero()
    {
        Debug.Log("skill shooted!");
        GaugeIndex -= Time.deltaTime;

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

        else
        {
            GaugeIndex = GaugeArray.Length - 1;
        }

    }


    //private IEnumerator GaugeCoolTime()
    //{
    //   // Debug.Log("코루틴실행전");
    //    //GaugeIndex = Mathf.Max(GaugeArray.Length - 1, 0);


    //    for(int i=GaugeArray.Length; i<0; --i)
    //    {

    //    }

    //    if (GaugeIndex <= 0)
    //    {
    //        GaugeIndex = 0;
    //        isShoot = true;
    //    }

    //   // Debug.Log("코루틴실행");
    //}
}