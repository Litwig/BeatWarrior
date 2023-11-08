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

    private FinalSkillGauge finalSkillGaugeScript;

    [SerializeField]
    private PlayerSkill playerSkillScript;

    [SerializeField]
    private CharacterData characterDataScript;

    #endregion SCRIPT

    #region GAUGE
    public GameObject[] GaugeArray;
    private float GaugeIndex;

    private float SkillGaugeIndex;
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
            finalSkillGaugeScript = GaugeArray[i].GetComponent<FinalSkillGauge>();
            //playerSkillScript.finalSkillGaugeScript = GaugeArray[characterDataScript.PlayerIndex].GetComponent<FinalSkillGauge>();
        }

        isDead = false;

        playerSkillScript.finalSkillGaugeScript = finalSkillGaugeScript;
       
        //SkillGaugeIndex = 0;
        // GaugeIndex = (int)gameManager.GetScore / 1000;
    }

    // Update is called once per frame

    private void Update()
    {
        if (playerScript.isDamaged)
        {
            Dead();
            playerScript.isDamaged = false;
        }

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
       if(finalSkillGaugeScript.GaugeIndex == finalSkillGaugeScript.GaugeArrayFullIndex)
       {
           playerSkillScript.isIndexFull = true;
       }

       else
       {
           playerSkillScript.isIndexFull = false;
       }
    }
}