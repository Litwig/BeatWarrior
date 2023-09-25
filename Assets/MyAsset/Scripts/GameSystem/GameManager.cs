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
    public int GaugeScore;

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
    public int GaugeIndex;
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
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerScript.isDamaged)
        {
            Dead();
            playerScript.isDamaged = false;
        }

        Score();
        PlayerRespawn();
        GetIndex();
        Debug.Log("Index:" + GaugeIndex);
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

        //1. ������� �޾��� ��, 2. ������� �ް� ���� ��
        //�� �� �����ؼ� ����� �޾��� �� 1���� Ȱ��ȭ�����ְ�
        // 1�� Ȱ��ȭ ��Ű�� 2�� Ȱ��ȭ��Ű��
        // �ѹ��� ȣ��Ǿ�� �� ���� �ΰ� �� �Ҽ�ȭ������ �־�� ����.
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

    private void GetIndex()
    {
        for(int i=0; i<GaugeArray.Length; ++i)
        {
            if (GaugeArray[i].activeSelf)
            {
                GaugeIndex = i;
            }
        }

    }
}