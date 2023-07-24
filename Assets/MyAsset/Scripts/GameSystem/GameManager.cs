using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region SCORE
    private float TimerCount;
    private float Min;
    public float GetScore;
    public float Minute;
    private float SpeedUp;
    #endregion

    #region Player
    private GameObject PlayerObj;
    private Player playerScript;
    private PlayerInfo playerInfoScript;
    public int PlayerScore;
    public bool isDead;
    #endregion

    #region Map
    [SerializeField]
    private GameObject SkyObject;
    [SerializeField]
    private GameObject[] MapPlatformObj;
    private QuadScript quadScript;
    private MapScroll mapScrollScript;
    #endregion

    #region SCRIPT
    [SerializeField]
    private SceneControll sceneControllScript;
    [SerializeField]
    private ReSpawn reSpawnScript;
    #endregion

    [SerializeField]
    private Transform PlayerSpawnPoint;
    

    void Start()
    {
        Time.timeScale = 1f;
        GetScore = 0;

        //PlayerObj = characterDataScript.CharacterPrefab;
       

        playerScript = PlayerObj.GetComponent<Player>();
        playerInfoScript = PlayerObj.GetComponent<PlayerInfo>();
        quadScript = SkyObject.GetComponent<QuadScript>();

        for(int mapScrollIndex = 0; mapScrollIndex < MapPlatformObj.Length; mapScrollIndex++)
        {
            mapScrollScript = MapPlatformObj[mapScrollIndex].GetComponent<MapScroll>();
        }

        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Dead();
        Score();
        //PotionHeal();
        //PlayerRespawn();
    }

    private void Score()
    {
        TimerCount += Time.deltaTime;

        SpeedUp = (int)TimerCount * 1000;
        GetScore = SpeedUp + PlayerScore;
           // sceneControllScript.isStart = false;
      
    }

    private void Dead()
    {
        if (playerScript.isDamaged == true) 
        {
            --playerInfoScript.PlayerHp;
            playerScript.isDamaged = false;
            
        }

        if(playerInfoScript.PlayerHp<=0)
        {
            GameOver();
            mapScrollScript.isGameOver = true;
            quadScript.isGameOver = true;
        }

    }

    private void PotionHeal()
    {
        if(playerScript.isPotion==true)
        {
            ++playerInfoScript.PlayerHp;
            if(playerInfoScript.PlayerHp==3)
            {
                return;
            }
        }
    }

    private void GameOver()
    {
        isDead = true;
    }

    private void PlayerRespawn()
    {
        if(playerScript.isFall==true)
        {
            playerInfoScript.PlayerHp = 0;
            playerScript.isFall = false;
        }
    }    
}
