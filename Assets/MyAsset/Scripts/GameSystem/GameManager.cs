using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private float TimerCount;
    private float Min;
    public float GetScore;
    public float Minute;
    private float SpeedUp;
    
    #region Player
    [SerializeField]
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
    [SerializeField]
    private Transform RespawnPoint;
    #endregion

    void Start()
    {
        Min = Time.time;
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
        Dead();
        Score();
        PotionHeal();
        PlayerRespawn();
    }

    private void Score()
    {
        TimerCount += Time.deltaTime;

        Minute = TimerCount - Min;
        SpeedUp = (int)Minute * 1000;
        GetScore = SpeedUp + PlayerScore;
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
        Debug.Log("GameOver");
    }

    private void PlayerRespawn()
    {
        if(playerScript.isFall==true)
        {
            PlayerObj.transform.position = RespawnPoint.position;
            playerScript.isFall = false;
            playerInfoScript.PlayerHp--;
        }
    }    
}
