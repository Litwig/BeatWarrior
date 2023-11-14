using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    #region SCORE

    private float TimerCount;
    private float Min;
    public float GetScore;
    public float Minute;
    private float SpeedUp;

    #endregion SCORE

    #region Player

    [SerializeField]
    private GameObject PlayerObj;

    private Player playerScript;
    private PlayerInfo playerInfoScript;
    public int PlayerScore;
    public bool isDead;

    #endregion Player

    #region Map

    [SerializeField]
    private GameObject SkyObject;

    [SerializeField]
    private GameObject[] MapPlatformObj;

    private QuadScript quadScript;
    private MapScroll mapScrollScript;

    #endregion Map

    #region SCRIPT

    [SerializeField]
    private SceneControll sceneControllScript;

    [SerializeField]
    private ReSpawn reSpawnScript;

    [SerializeField]
    private CameraShake cameraShakeScript;

    private SelectGrey selectGreyScript;

    [SerializeField]
    private FinalSkillGauge finalSkillGaugeScript;
    
    [SerializeField]
    private GaugeUI GaugeUIScript;

    [SerializeField]
    private PlayerSkill playerSkillScript;

    [SerializeField]
    private CharacterData characterDataScript;

    #endregion SCRIPT

    #region GAUGE
    public GameObject[] GaugeArray;
    private float GaugeIndex;

    private float SkillGaugeIndex;
    private float putUI_Index; //ui스크립트에 게이지 스크립트의 인덱스 넣어줌.

    private bool isGaugeFull; //ui 게이지 스크립트가 인덱스 다 찼냐... 
    
    #endregion GAUGE

    [SerializeField]
    private Transform PlayerSpawnPoint;

    private void Start()
    {
        //yield return new WaitForSeconds(1f);
        GetScore = 0;
        Time.timeScale = 1f;
        PlayerObj = reSpawnScript.Character;

        playerScript = PlayerObj.GetComponent<Player>();
        playerInfoScript = PlayerObj.GetComponent<PlayerInfo>();
        selectGreyScript = PlayerObj.GetComponent<SelectGrey>();
        quadScript = SkyObject.GetComponent<QuadScript>();
        playerSkillScript = PlayerObj.GetComponent<PlayerSkill>();
        
        selectGreyScript.ColorType = SelectGrey.COLORTYPE.STAGE_TYPE;
        characterDataScript = GameObject.FindWithTag("GameSystem").GetComponent<CharacterData>();

        for (int mapScrollIndex = 0; mapScrollIndex < MapPlatformObj.Length; mapScrollIndex++)
        {
            mapScrollScript = MapPlatformObj[mapScrollIndex].GetComponent<MapScroll>();
        }

        for (int i = 0; i < GaugeArray.Length; ++i)
        {
            if (i == CharacterData.instance.PlayerIndex)
            {
                finalSkillGaugeScript = GaugeArray[i].GetComponent<FinalSkillGauge>();
                GaugeUIScript = GaugeArray[i].GetComponent<GaugeUI>();
            }
            else
                continue;
            
            //playerSkillScript.finalSkillGaugeScript = GaugeArray[characterDataScript.PlayerIndex].GetComponent<FinalSkillGauge>();
        }

        isDead = false;

        playerSkillScript.finalSkillGaugeScript = finalSkillGaugeScript;
       
    }

    // Update is called once per frame

    private void Update()
    {
        if (playerScript.isDamaged)
        {
            Dead();
            playerScript.isDamaged = false;
        }

        if (finalSkillGaugeScript == null)
            Debug.Log("SkillScript is null");

        if (GaugeUIScript == null)
            Debug.Log("gaugeuiScript is null");

        Debug.Log("SkillGaugeIndex: " + SkillGaugeIndex);
        Score();
        PlayerRespawn();
        GaugeManager();
    }

    private void Score()
    {
        TimerCount += Time.deltaTime;

        SpeedUp = (int)TimerCount * 1000;
        GetScore = SpeedUp + PlayerScore;
        //sceneControllScript.isStart = false;
    }

    private void Dead()
    {
        cameraShakeScript.isDamage = true;
        StartCoroutine(nameof(ColorChange));
        --playerInfoScript.PlayerHp;

        if (playerInfoScript.PlayerHp <= 0)
        {
            GameOver();
            Debug.Log("Player Damage");
            mapScrollScript.isGameOver = true;
            quadScript.isGameOver = true;
        }
        //if collision with player and monster
        //I want --PlayerHp
        //but it Collision, than Player just dying
        // Player : X(

        //1. 대미지를 받았을 때, 2. 대미지를 받고 있을 때
        //두 개 선언해서 대미지 받았을 때 1번거 활성화시켜주고
        // 1번 활성화 시키면 2번 활성화시키고
        // 한번만 호출되어야 할 때는 두개 다 할성화시켜져 있어야 가능.
    }

    private void GameOver()
    {
        isDead = true;
    }

    private void PlayerRespawn()
    {
        if (playerScript.isFall == true)
        {
            playerInfoScript.PlayerHp = 0;
            playerScript.isFall = false;
        }
    }

    private IEnumerator ColorChange()
    {
        PlayerObj.layer = 7;
        selectGreyScript.SpriteColor(Color.red);
        yield return new WaitForSeconds(cameraShakeScript.ShakeTime);
        selectGreyScript.SpriteColor(Color.white);
        PlayerObj.layer = 8;
        playerScript.isDamaged = false;
    }

    private void GaugeManager()
    {
        for(int i=0; i<GaugeArray.Length; ++i)
        {
            if (CharacterData.instance.PlayerIndex == i)
            {
                GaugeArray[i].SetActive(true);
            }

            else
            {
                GaugeArray[i].SetActive(false);
            }
        }

        GaugeUIScript.GaugeUI_Index = (int)finalSkillGaugeScript.GaugeIndex;
        //final Gauge script에서 
        if (GaugeUIScript.GaugeUI_Index == GaugeUIScript.GaugeUI_Index - 1) //게이지 다 참
        {
            GaugeUIScript.GaugeUI_Index = GaugeUIScript.GaugeArray.Length - 1;
            playerSkillScript.isIndexFull = true;
        }

        else
        {
            playerSkillScript.isIndexFull = false;
        }

        if(finalSkillGaugeScript.isShoot)
        {
            GaugeUIScript.isGaugeLess = true;
        }
        else
        {
            GaugeUIScript.isGaugeLess = false;
        }
    }
}